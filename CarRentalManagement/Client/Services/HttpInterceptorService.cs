﻿using Microsoft.AspNetCore.Components;
using Toolbelt.Blazor;

namespace CarRentalManagement.Client.Services
{
    public class HttpInterceptorService
    {
        private readonly HttpClientInterceptor interceptor;
        private readonly NavigationManager navManager;

        public HttpInterceptorService(HttpClientInterceptor interceptor, NavigationManager navManager)
        {
            this.interceptor = interceptor;
            this.navManager = navManager;
        }

        public void MonitorEvent() => interceptor.AfterSend += InterceptResponse;

        private void InterceptResponse(object? sender, HttpClientInterceptorEventArgs e)
        {
            string message = string.Empty;
            if (!e.Response.IsSuccessStatusCode)
            {
                var responseCode = e.Response.StatusCode;

                switch (responseCode)
                {
                    case System.Net.HttpStatusCode.NotFound:
                        navManager.NavigateTo("/404");
                        message = "The request resource was not found";
                        break;
                    case System.Net.HttpStatusCode.Unauthorized:
                    case System.Net.HttpStatusCode.Forbidden:
                        navManager.NavigateTo("/unauthorized");
                        message = "You are not authorized to access this resource";
                        break;
                    default:
                        navManager.NavigateTo("/500");
                        message = "Something went wrong, please contact Administrator";
                        break;
                }
                throw new Exception(message);
            }
        }

        public void DisposeEvent() => interceptor.AfterSend -= InterceptResponse;
    }
}