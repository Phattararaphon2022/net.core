using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR
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

           
            services.AddControllers();
            

            APIiHR.Business.Binder.Setup(services);
            APIiHR.DataAccess.Binder.Setup(services, Configuration);

            //enable open cors not secu
            services.AddCors();
            //services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            //services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);


            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "APIiHR", Version = "v1" });
            });
            /*
            services.AddCors(options =>
            {
                options.AddPolicy(
                        name: "AllowOrigin",
                        builder =>
                        {
                            builder.AllowAnyOrigin()
                            .AllowAnyMethod()
                            .AllowAnyHeader();
                        });
            });
            */
            services.AddCors();
            /*
            services.AddCors(options => options.AddPolicy("ServiceOrigin", builder =>
            {
                builder.AllowAnyOrigin()
               .AllowAnyMethod()
                .AllowAnyHeader();
            }));
            */

          //  services.AddScoped(x => new BlobServiceClient(Configuration.GetValue<string>("AzureBlobStorage")));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //app.UseCors("AllowOrigin");
            //options.WithOrigins(Configuration.GetConnectionString("Connport"),"localhost:8801")

            app.UseCors(options =>
                    // options.WithOrigins(Configuration.GetConnectionString("Connport"), "localhost:8802")
                    options.WithOrigins(Configuration.GetConnectionString("Connport"))
                    .AllowAnyHeader()
                    .AllowCredentials()
                    .SetIsOriginAllowed((host) => true)
                    .AllowAnyMethod());
            
            /*
            .AllowAnyHeader()
            //.SetIsOriginAllowed(origin => true)
            //.AllowCredentials()         

            //.AllowAnyOrigin()                    
            .AllowAnyMethod());
    */

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "APIiHR v1"));
            }

            app.UseRouting();

           // app.UseHttpsRedirection();

            app.UseAuthorization();

          //  app.UseHttpsRedirection();
           

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            //upload file
            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(
                    //Path.Combine(Directory.GetCurrentDirectory(), "Filemanager")),
                //RequestPath = "/Filemanager"
                Path.Combine(Directory.GetCurrentDirectory(), "FileInfo")),
                RequestPath = "/FileInfo"
            });

        }
    }
}
