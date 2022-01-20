using CarRentalManagement.Client.Services;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Net.Http.Json;

namespace CarRentalManagement.Client.Pages.Colors
{
    public partial class Index : IDisposable
    {
        [Inject] HttpClient client { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [Inject] HttpInterceptorService interceptor { get; set; }

        private List<Color> Colors;

        protected async override Task OnInitializedAsync()
        {
            Console.WriteLine("Hitting Code Behind");
            interceptor.MonitorEvent();
            Colors = await client.GetFromJsonAsync<List<Color>>($"{Endpoints.ColorsEndpoint}");
        }

        private async Task Delete(int colorId)
        {
            var color = Colors.First(q => q.Id == colorId);

            var confirm = (await js.InvokeAsync<bool>("confirm", $"Do you want to delete {color.Name}?"));
            if (confirm)
            {
                interceptor.MonitorEvent();
                await client.DeleteAsync($"{Endpoints.ColorsEndpoint}/{colorId}");
                await OnInitializedAsync();
            }
        }

        public void Dispose()
        {
            interceptor.DisposeEvent();
        }
    }
}
