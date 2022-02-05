using CarRentalManagement.Client.Contracts;
using CarRentalManagement.Client.Services;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace CarRentalManagement.Client.Pages.Brands
{
    public partial class Create
    {
        [Inject] IHttpRepository<Brand> client { get; set; }
        [Inject] NavigationManager navManager { get; set; }
        Brand brand = new Brand();

        private async Task CreateBrand()
        {
            await client.Create(Endpoints.BrandsEndpoint, brand);
            navManager.NavigateTo("/brands/");
        }
    }
}
