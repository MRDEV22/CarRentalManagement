using CarRentalManagement.Client.Services;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace CarRentalManagement.Client.Pages.Customers
{
    public partial class Edit : IDisposable
    {
        [Inject] HttpClient client { get; set; }
        [Inject] NavigationManager navManager { get; set; }
        [Inject] HttpInterceptorService interceptor { get; set; }

        [Parameter] public int id { get; set; }
        Customer customer = new Customer();

        protected async override Task OnParametersSetAsync()
        {
            customer = await client.GetFromJsonAsync<Customer>($"{Endpoints.CustomersEndpoint}/{id}");
        }

        async Task EditCustomer()
        {
            await client.PutAsJsonAsync($"{Endpoints.CustomersEndpoint}/{id}", customer);
            navManager.NavigateTo("/customers/");
        }

        public void Dispose()
        {
            interceptor.DisposeEvent();
        }
    }
}
