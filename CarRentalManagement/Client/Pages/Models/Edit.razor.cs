using CarRentalManagement.Client.Services;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace CarRentalManagement.Client.Pages.Models
{
    public partial class Edit : IDisposable
    {
        [Inject] HttpClient client { get; set; }
        [Inject] NavigationManager navManager { get; set; }
        [Inject] HttpInterceptorService interceptor { get; set; }
        [Parameter] public int id { get; set; }
        Model model = new Model();

        protected async override Task OnParametersSetAsync()
        {
            model = await client.GetFromJsonAsync<Model>($"{Endpoints.ModelsEndpoint}/{id}");
        }

        async Task EditModel()
        {
            await client.PutAsJsonAsync($"{Endpoints.ModelsEndpoint}/{id}", model);
            navManager.NavigateTo("/models/");
        }
        public void Dispose()
        {
            interceptor.DisposeEvent();
        }
    }
}
