using RoyalERP.WebApp.Shared.API.Orders;
using Refit;
using RoyalERP.WebApp.Shared.API.WorkOrders;
using RoyalERP.WebApp.Shared.API.Companies;
using RoyalERP.WebApp.Shared.API.Events;
using RoyalERP.WebApp.Shared.API.Products;
using RoyalERP.WebApp.Shared.API.ProductClasses;

namespace RoyalERP.WebApp.Shared.API;

public static class DependencyInjection {

    public static IServiceCollection AddApi(this IServiceCollection services, IConfiguration configuration) {

        string host = configuration["Host"];

        return services.AddScoped<ICompanyAPI>(s => new ExampleCompanyData())
                        .AddScoped<IOrderAPI>(s => new ExampleOrderData())
                        .AddScoped<IWorkOrderAPI>(s => new ExampleWorkOrderData())
                        .AddScoped<IEventAPI>(s => new ExampleEventData())
                        .AddScoped<IProductAPI>(s => new ExampleProductData())
                        .AddScoped<IProductClassAPI>(s => new ExampleProductClassData());

        /*return services.AddScoped(s => RestService.For<IOrderAPI>(host))
                        .AddScoped(s => RestService.For<ICompanyAPI>(host))
                        .AddScoped(s => RestService.For<IWorkOrderAPI>(host));*/

    }

}
