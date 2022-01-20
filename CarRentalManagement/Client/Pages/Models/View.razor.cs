using CarRentalManagement.Client.Services;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace CarRentalManagement.Client.Pages.Models
{
    public partial class View: IDisposable
    {

        [Inject] HttpClient client { get; set; }
        [Inject] HttpInterceptorService interceptor { get; set; }

        [Parameter] public int id { get; set; }
        Model model = new Model();

        protected async override Task OnParametersSetAsync()
        {
            model = await client.GetFromJsonAsync<Model>($"{Endpoints.ModelsEndpoint}/{id}");
        }

        public void Dispose()
        {
            interceptor.DisposeEvent();
        }
    }
}
