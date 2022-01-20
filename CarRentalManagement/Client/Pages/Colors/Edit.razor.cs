using CarRentalManagement.Client.Services;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Net.Http.Json;

namespace CarRentalManagement.Client.Pages.Colors
{
    public partial class Edit : IDisposable
    {
        [Inject] HttpClient client { get; set; }
        [Inject] NavigationManager navManager { get; set; }
        [Inject] HttpInterceptorService interceptor { get; set; }

        [Parameter] public int id { get; set; }
        Color color = new Color();

        protected async override Task OnParametersSetAsync()
        {
            color = await client.GetFromJsonAsync<Color>($"{Endpoints.ColorsEndpoint}/{id}");
        }

        async Task EditColor()
        {
            await client.PutAsJsonAsync($"{Endpoints.ColorsEndpoint}/{id}", color);
            navManager.NavigateTo("/colors/");
        }

        public void Dispose()
        {
            interceptor.DisposeEvent();
        }
    }
}
