using CarRentalManagement.Client.Services;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace CarRentalManagement.Client.Pages.Vehicles
{
    public partial class Create : IDisposable
    {
        [Inject] HttpClient client { get; set; }
        [Inject] NavigationManager navManager { get; set; }
        [Inject] HttpInterceptorService interceptor { get; set; }

        Vehicle vehicle = new Vehicle();
        private IList<Brand> Brands;
        private IList<Model> Models;
        private IList<Color> Colors;

        protected async override Task OnInitializedAsync()
        {
            Brands = await client.GetFromJsonAsync<List<Brand>>($"{Endpoints.BrandsEndpoint}");
            Colors = await client.GetFromJsonAsync<List<Color>>($"{Endpoints.ColorsEndpoint}");
            Models = await client.GetFromJsonAsync<List<Model>>($"{Endpoints.ModelsEndpoint}");
        }

        private async Task CreateVehicle()
        {
            interceptor.MonitorEvent();
            await client.PostAsJsonAsync(Endpoints.VehiclesEndpoint, vehicle);
            navManager.NavigateTo("/vehicles/");
        }
        public void Dispose()
        {
            interceptor.DisposeEvent();
        }
    }
}
