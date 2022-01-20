using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Net.Http.Json;

namespace CarRentalManagement.Client.Pages.Bookings
{
    public partial class Index
    {
        [Inject] HttpClient client { get; set; }
        [Inject] IJSRuntime js { get; set; }

        private List<Booking> Bookings;

        protected async override Task OnInitializedAsync()
        {
            Bookings = await client.GetFromJsonAsync<List<Booking>>($"{Endpoints.BookingsEndpoint}");
        }

        private async Task Delete(int bookingId)
        {
            var booking = Bookings.First(q => q.Id == bookingId);

            var confirm = (await js.InvokeAsync<bool>("confirm", $"Do you want to delete {booking.Customer}?"));
            if (confirm)
            {
                await client.DeleteAsync($"{Endpoints.BookingsEndpoint}/{bookingId}");
                await OnInitializedAsync();
            }

        }
    }
}
