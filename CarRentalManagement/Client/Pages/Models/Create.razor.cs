using CarRentalManagement.Client.Services;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace CarRentalManagement.Client.Pages.Models
{
    public partial class Create : IDisposable
    {
        [Inject] HttpClient client { get; set; }
        [Inject] NavigationManager navManager { get; set; }
        [Inject] HttpInterceptorService interceptor { get; set; }

        Model model = new Model();

        private async Task CreateModel()
        {
            await client.PostAsJsonAsync(Endpoints.ModelsEndpoint, model);
            navManager.NavigateTo("/models/");
        }

        public void Dispose()
        {
            interceptor.DisposeEvent();
        }
    }
}
