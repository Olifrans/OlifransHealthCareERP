using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using OlifransHealthCareERP.Data.Context;
using OlifransHealthCareERP.Data.Repository;
using OlifransHealthCareERP.Manager.Implementation;
using OlifransHealthCareERP.Manager.Interfaces;
using OlifransHealthCareERP.Manager.Mappings;
using OlifransHealthCareERP.Manager.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlifransHealthCareERP.Api
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
            services.AddControllers()
                .AddFluentValidation(p=>
                { 
                    p.RegisterValidatorsFromAssemblyContaining<ClienteNovoValidator>();
                    p.ValidatorOptions.LanguageManager.Culture = new System.Globalization.CultureInfo("pt-BR"); //Retorno do idioma de  mensagem do validor
                });  //Validação do FluentValidation

            services.AddAutoMapper(typeof(ClienteNovoMappingProfile)); //Auto Mapping


            services.AddDbContext<ContextDBOlifransHealthCare>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("ConexOlifransHealthCare")));

            //Injeção de dependência
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IClienteManager, ClienteManager>();


            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "OlifransHealthCareERP.Api", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "OlifransHealthCareERP.Api v1"));
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
