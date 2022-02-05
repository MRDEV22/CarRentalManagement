using CarRentalManagement.Client.Contracts;
using System.Net.Http.Json;

namespace CarRentalManagement.Client.Services
{
    public class HttpRepository<T> : IDisposable, IHttpRepository<T> where T : class
    {
        private readonly HttpClient client;
        private readonly HttpInterceptorService interceptor;
        public HttpRepository(HttpClient httpClient, HttpInterceptorService httpInterceptorService)
        {
            client = httpClient;
            interceptor = httpInterceptorService;
        }

        public async Task Create(string url, T obj)
        {
            interceptor.MonitorEvent();
            await client.PostAsJsonAsync(url, obj);
        }

        public async Task Delete(string url, int id)
        {
            interceptor.MonitorEvent();
            await client.DeleteAsync($"{url}/{id}");
        }

        public void Dispose()
        {
            interceptor.DisposeEvent();
        }

        public async Task<T> Get(string url, int id)
        {
            interceptor.MonitorEvent();
            return await client.GetFromJsonAsync<T>($"{url}/{id}");
        }

        public async Task<IList<T>> GetAll(string url)
        {
            interceptor.MonitorEvent();
            return await client.GetFromJsonAsync<IList<T>>($"{url}");
        }

        public async Task<T> GetDetails(string url, int id)
        {
            interceptor.MonitorEvent();
            return await client.GetFromJsonAsync<T>($"{url}/{id}/details");
        }

        public async Task Update(string url, T obj, int id)
        {
            interceptor.MonitorEvent();
            await client.PutAsJsonAsync($"{url}/{id}", obj);
        }
    }
}
