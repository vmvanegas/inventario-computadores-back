using Microsoft.Extensions.DependencyInjection;
using Mispollos.Application.Services;
using Mispollos.Domain.Contracts.Services;

namespace Mispollos.Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IProviderService, ProviderService>();
            services.AddScoped<IDashboardService, DashboardService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IOrderItemService, OrderItemService>();
            services.AddScoped<ILaptopService, LaptopService>();
            services.AddScoped<IBaseDeMaderaService, BaseDeMaderaService>();
            services.AddScoped<ICableVGAService, CableVGAService>();
            services.AddScoped<ICargadorService, CargadorService>();
            services.AddScoped<IDiademaService, DiademaService>();
            services.AddScoped<IMonitorService, MonitorService>();
            services.AddScoped<IMouseService, MouseService>();
            services.AddScoped<ITecladoService, TecladoService>();

            return services;
        }
    }
}