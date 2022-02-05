using CarRentalManagement.Client.Services;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace CarRentalManagement.Client.Pages.Brands
{
    public partial class View:IDisposable
    {
        [Inject] HttpClient client { get; set; }
        [Inject] HttpInterceptorService interceptor { get; set; }
        [Parameter] public int id { get; set; }

        Brand brand = new Brand();

        protected async override Task OnParametersSetAsync()
        {
            brand = await client.GetFromJsonAsync<Brand>($"{Endpoints.BrandsEndpoint}/{id}");
        }

        public void Dispose()
        {
            interceptor.DisposeEvent();
        }
    }
}
