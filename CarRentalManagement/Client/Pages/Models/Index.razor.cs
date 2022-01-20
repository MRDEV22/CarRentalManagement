using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Net.Http.Json;

namespace CarRentalManagement.Client.Pages.Models
{
    public partial class Index : IDisposable
    {
        [Inject] HttpClient client { get; set; }
        [Inject] IJSRuntime js { get; set; }
        private List<Model> Models;

        protected async override Task OnInitializedAsync()
        {
            Models = await client.GetFromJsonAsync<List<Model>>($"{Endpoints.ModelsEndpoint}");
        }

        private async Task Delete(int modelId)
        {
            var model = Models.First(q => q.Id == modelId);

            var confirm = (await js.InvokeAsync<bool>("confirm", $"Do you want to delete {model.Name}?"));
            if (confirm)
            {
                await client.DeleteAsync($"{Endpoints.ModelsEndpoint}/{modelId}");
                await OnInitializedAsync();
            }

        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
