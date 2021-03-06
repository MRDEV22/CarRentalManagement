using CarRentalManagement.Client.Contracts;
using CarRentalManagement.Client.Services;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace CarRentalManagement.Client.Pages.Colors
{
    public partial class Create
    {
        [Inject] IHttpRepository<Color> client { get; set; }
        [Inject] NavigationManager navManager { get; set; }

        Color color = new Color();

        private async Task CreateColor()
        {
            await client.Create(Endpoints.ColorsEndpoint, color);
            navManager.NavigateTo("/colors/");
        }
    }
}
