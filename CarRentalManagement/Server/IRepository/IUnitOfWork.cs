using CarRentalManagement.Shared.Domain;

namespace CarRentalManagement.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Brand> Brands { get; }
        IGenericRepository<Booking> Bookings { get; }
        IGenericRepository<Color> Colors { get; }
        IGenericRepository<Customer> Customer { get; }
        IGenericRepository<Model> Models { get; }
        IGenericRepository<Vehicle> Vehicles { get; }
    }
}
