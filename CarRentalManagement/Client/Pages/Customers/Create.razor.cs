using CarRentalManagement.Client.Services;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace CarRentalManagement.Client.Pages.Customers
{
    public partial class Create : IDisposable
    {
        [Inject] HttpClient client { get; set; }
        [Inject] NavigationManager navManager { get; set; }
        [Inject] HttpInterceptorService interceptor { get; set; }

        Customer customer = new Customer();

        private async Task CreateCustomer()
        {
            await client.PostAsJsonAsync(Endpoints.CustomersEndpoint, customer);
            navManager.NavigateTo("/customers/");
        }

        public void Dispose()
        {
            interceptor.DisposeEvent();
        }
    }
}
