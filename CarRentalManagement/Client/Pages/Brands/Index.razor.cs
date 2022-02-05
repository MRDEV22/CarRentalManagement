using CarRentalManagement.Client.Services;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Net.Http.Json;

namespace CarRentalManagement.Client.Pages.Brands
{
    public partial class Index : IDisposable
    {
        [Inject] HttpClient client { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [Inject] HttpInterceptorService interceptor { get; set; }
        private List<Brand> Brands;

        protected async override Task OnInitializedAsync()
        {
            Brands = await client.GetFromJsonAsync<List<Brand>>($"{Endpoints.BrandsEndpoint}");
        }

        private async Task Delete(int brandId)
        {
            var brand = Brands.First(q => q.Id == brandId);

            var confirm = (await js.InvokeAsync<bool>("confirm", $"Do you want to delete {brand.Name}?"));
            if (confirm)
            {
                await client.DeleteAsync($"{Endpoints.BrandsEndpoint}/{brandId}");
                await OnInitializedAsync();
            }

        }
        public void Dispose()
        {
            interceptor.DisposeEvent();
        }
    }
}
