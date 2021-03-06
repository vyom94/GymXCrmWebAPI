using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CRM.Data.Repository;
using CRM.Framework.Repositories;
using CRM.Framework.Services;
using CRM.Framework.UnitOfWork;
using CRM.Infrastructure.Settings;
using GymXCrmAPI.Handler;
using GymXCrmAPI.Middleware;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

namespace GymXCrmAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Settings = new Settings(configuration);
            Configuration = configuration;
        }
        public ISettings Settings { get; set; }
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "GymXCrmAPI", Version = "v1" });
            });

            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Settings.ConnectionString.GymXCrmDB));
            services.AddCors(options =>
            {
                options.AddPolicy(name: "CorsPolicy",
                                builder =>
                                {
                                    builder.AllowAnyOrigin()
                                            .AllowAnyMethod()
                                            .AllowAnyHeader();

                                });
            });

            string domain = $"https://{Configuration["Auth0:Domain"]}/";
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.Authority = domain;
                options.Audience = Configuration["Auth0:Audience"];
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    NameClaimType = ClaimTypes.NameIdentifier
                };
            });

            services.AddAuthorization(options =>
            {
                //options.AddPolicy("read:weather", policy => policy.Requirements.Add(new HasScopeRequirement("read:weather", $"https://{Configuration["Auth0:Domain"]}/")));
            });


            services.AddSingleton<IAuthorizationHandler, HasScopeHandler>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IUnitOfWork>();
           
            //services.AddScoped(typeof(IService<>), typeof(Service<>));
            //services.AddControllers()
            //   .AddNewtonsoftJson(options =>
            //   {
            //       options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            //   });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "GymXCrmAPI v1"));
            }

            //app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors("CorsPolicy");
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
         
        }
    }
}
