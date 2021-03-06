﻿using Microsoft.Owin;
using DotNetDoodle.Owin.Dependencies;
using DotNetDoodle.Owin.Dependencies.Adapters.WebApi.Infrastructure;
using System.Web.Http.Dependencies;

namespace System.Net.Http
{
    internal static class OwinHttpRequestMessageExtensions
    {
        internal static IDependencyScope GetOwinDependencyScope(this HttpRequestMessage request)
        {
            IServiceProvider requestContainer = request.GetOwinContext().Environment.GetRequestContainer();
            return new OwinDependencyScopeWebApiAdapter(requestContainer);
        }
    }
}