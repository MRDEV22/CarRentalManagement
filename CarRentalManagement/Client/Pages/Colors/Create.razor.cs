using CarRentalManagement.Client.Services;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace CarRentalManagement.Client.Pages.Colors
{
    public partial class Create : IDisposable
    {
        [Inject] HttpClient client { get; set; }
        [Inject] NavigationManager navManager { get; set; }
        [Inject] HttpInterceptorService interceptor { get; set; }

        Color color = new Color();

        private async Task CreateColor()
        {
            interceptor.MonitorEvent();
            await client.PostAsJsonAsync(Endpoints.ColorsEndpoint, color);
            navManager.NavigateTo("/colors/");
        }

        public void Dispose()
        {
            interceptor.DisposeEvent();
        }
    }
}
