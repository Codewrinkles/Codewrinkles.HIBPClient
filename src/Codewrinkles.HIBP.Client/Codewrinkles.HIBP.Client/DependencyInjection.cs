using Codewrinkles.HIBP.Client.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewrinkles.HIBP.Client
{
    public static class DependencyInjection
    {

        public static IServiceCollection AddHibpClient(this IServiceCollection services, string apiKey)
        {
            var client = HttpClientFactory.CreateDefault(apiKey);
            services.AddSingleton<IHibpClient>(sp => new HibpClient(client));
            return services;
        }
       

    }
}
