using Microsoft.EntityFrameworkCore;
using Proyecto_Poo.Helpers;
using Proyecto_Poo.Service.Interface;
using Proyecto_Poo.Service;
using Examen_2__Josue_David.DataBase.Context;
using Examen_2__Josue_David.Service.Interface;
using Examen_2__Josue_David.Service;

namespace Examen_2__Josue_David
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            // Add DbContext
            services.AddDbContext<GestionDeTiendaDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            // Add custom services
            services.AddTransient<IPrestamoService, PrestamoService>(); // Cambiado de ICategoriesService a ICustomerService
            services.AddTransient<IAuthService, AuthService>();
            //services.AddTransient<IPackageService, PackageService>(); // Cambiado de IPostsService a IOrderService

            // Add AutoMapper
            services.AddAutoMapper(typeof(AutoMapperProfile)); // Asegúrate de que AutoMapperProfile esté correctamente definido

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }



    }
}


