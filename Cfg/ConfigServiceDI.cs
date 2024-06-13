using Frame_Manager.Repository;
using Frame_Manager.Service;

namespace Frame_Manager.Cfg
{
    public static class Service
    {
        public static void ConfigServiceDI(this IServiceCollection services)
        {
            services.AddScoped<HistoryRepository>();
            services.AddScoped<CounterService>();
        }
    }
}
