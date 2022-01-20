using CarRentalManagement.Client.Services;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace CarRentalManagement.Client.Pages.Vehicles
{
    public partial class Edit : IDisposable
    {
        [Inject] HttpClient client { get; set; }
        [Inject] NavigationManager navManager { get; set; }
        [Inject] HttpInterceptorService interceptor { get; set; }

        [Parameter] public int id { get; set; }
        Vehicle vehicle = new Vehicle();

        protected async override Task OnParametersSetAsync()
        {
            vehicle = await client.GetFromJsonAsync<Vehicle>($"{Endpoints.VehiclesEndpoint}/{id}");
        }

        async Task EditVehicle()
        {
            await client.PutAsJsonAsync($"{Endpoints.VehiclesEndpoint}/{id}", vehicle);
            navManager.NavigateTo("/vehicles/");
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
