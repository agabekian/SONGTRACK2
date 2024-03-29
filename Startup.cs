using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using cSharp2022.Models;
using Microsoft.EntityFrameworkCore;

namespace cSharp2022
{
    public class Startup
    {
        public Startup(IConfiguration configuration){ Configuration = configuration; }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            //note adding Muh context here.
            services.AddDbContext<MuhContext>(options => options.UseMySql(Configuration["DBInfo:ConnectionString"]));
            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddMvc().AddSessionStateTempDataProvider();
            services.AddSession();
            // services.Configure<FormOptions>(opt =>
            // {
            //     opt.MultipartBodyLengthLimit = 52428800;
            // });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseSession();
            app.UseMvc();
        }
    }
}