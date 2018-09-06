using EstudioAbogados.Application.AbogadoApp;
using EstudioAbogados.Infraestructure.EFCore;
using EstudioAbogados.Infraestructure.EFCore.Uow;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EstudioAbogados.Web.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddDbContext<EstudioAbogadosDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Default")));

            services.AddScoped<IUnitOfWorkEstudioAbogados, UnitOfWorkEstudioAbogados>();

            services.AddScoped<IAbogadoAppService, AbogadoAppService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(options => options.WithOrigins("http://localhost:4200").AllowAnyMethod());

            app.UseMvc();
        }
    }
}
