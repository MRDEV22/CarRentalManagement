using CarRentalManagement.Client.Services;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace CarRentalManagement.Client.Pages.Colors
{
    public partial class View : IDisposable
    {
        [Inject] HttpClient client { get; set; }
        [Inject] HttpInterceptorService interceptor { get; set; }

        [Parameter] public int id { get; set; }
        Color color = new Color();

        protected async override Task OnParametersSetAsync()
        {
            color = await client.GetFromJsonAsync<Color>($"{Endpoints.ColorsEndpoint}/{id}");
        }

        public void Dispose()
        {
            interceptor.DisposeEvent();
        }
    }
}
