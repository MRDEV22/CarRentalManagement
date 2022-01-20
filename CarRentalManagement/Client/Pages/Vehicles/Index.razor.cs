using CarRentalManagement.Client.Services;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Net.Http.Json;

namespace CarRentalManagement.Client.Pages.Vehicles
{
    public partial class Index : IDisposable
    {
        [Inject] HttpClient client { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [Inject] HttpInterceptorService interceptor { get; set; }

        private List<Vehicle> Vehicles;

        protected async override Task OnInitializedAsync()
        {
            Vehicles = await client.GetFromJsonAsync<List<Vehicle>>($"{Endpoints.VehiclesEndpoint}");
        }

        private async Task Delete(int vehicleId)
        {
            var vehicle = Vehicles.First(q => q.Id == vehicleId);

            var confirm = (await js.InvokeAsync<bool>("confirm", $"Do you want to delete {vehicle.Vin}?"));
            if (confirm)
            {
                await client.DeleteAsync($"{Endpoints.VehiclesEndpoint}/{vehicleId}");
                await OnInitializedAsync();
            }

        }
        public void Dispose()
        {
            interceptor.DisposeEvent();
        }
    }
}
