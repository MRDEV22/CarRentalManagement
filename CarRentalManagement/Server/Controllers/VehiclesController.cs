#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarRentalManagement.Server.Data;
using CarRentalManagement.Shared.Domain;
using CarRentalManagement.Server.IRepository;

namespace CarRentalManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public VehiclesController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            this._webHostEnvironment = webHostEnvironment;
            this._httpContextAccessor = httpContextAccessor;
        }

        // GET: api/Vehicles
        [HttpGet]
        public async Task<IActionResult> GetVehicles()
        {
            var vehicles = await _unitOfWork.Vehicles.GetAll(includes: q => q.Include(x => x.Brand).Include(x => x.Model).Include(x => x.Color));
            return Ok(vehicles);
        }

        // GET: /Vehicles/5
        [HttpGet]
        public async Task<IActionResult> GetVehicle(int id)
        {
            var vehicle = await _unitOfWork.Vehicles.Get(q => q.Id == id);
            if (vehicle == null)
            {
                return NotFound();
            }

            return Ok(vehicle);
        }

        // GET: /Vehicles/5/details
        [HttpGet("{id}/details")]
        public async Task<IActionResult> GetVehicleDetails(int id)
        {
            var vehicle = await _unitOfWork.Vehicles.Get(q => q.Id == id, includes: q => q.Include(x => x.Brand).Include(x => x.Model).Include(x => x.Color));

            if (vehicle == null)
            {
                return NotFound();
            }

            return Ok(vehicle);
        }

        // PUT: api/Vehicles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVehicle(int id, Vehicle vehicle)
        {
            if (id != vehicle.Id)
            {
                return BadRequest();
            }
            if (vehicle.Image != null)
            {
                vehicle.ImageName = CreateFile(vehicle.Image, vehicle.ImageName);
            }
            _unitOfWork.Vehicles.Update(vehicle);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VehicleExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Vehicles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Vehicle>> PostVehicle(Vehicle vehicle)
        {
            if (vehicle.Image != null)
            {
                vehicle.ImageName = CreateFile(vehicle.Image, vehicle.ImageName);
            }

            await _unitOfWork.Vehicles.Insert(vehicle);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetVehicle", new { id = vehicle.Id }, vehicle);
        }

        // DELETE: api/Vehicles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVehicle(int id)
        {
            var vehicle = await _unitOfWork.Vehicles.Get(q => q.Id == id);
            if (vehicle == null)
            {
                return NotFound();
            }

            await _unitOfWork.Vehicles.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private string CreateFile(byte[] image, string name)
        {
            var url = _httpContextAccessor.HttpContext.Request.Host.Value;
            var path = $"{_webHostEnvironment.WebRootPath}\\uploads\\{image}";
            var fileStream = System.IO.File.Create(path);
            fileStream.Write(image, 0, image.Length);
            fileStream.Close();
            return $"https://{url}/uploads/{name}";
        }

        private bool VehicleExists(int id)
        {
            var vehicle = _unitOfWork.Vehicles.Get(q => q.Id == id);
            return vehicle != null;
        }
    }
}
