﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiouseAPI.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;

namespace FiouseAPI
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddDbContext<FiouseContext>(options => {
                options.UseSqlServer($"Server=tcp:fiouse.database.windows.net,1433;" +
                    $"Initial Catalog=FiouseAPI;" +
                    $"Persist Security Info=False;" +
                    $"User ID={Secrets.AzureSQLUser};" +
                    $"Password={Secrets.AzureSQLPassword};" +
                    $"MultipleActiveResultSets=False;" +
                    $"Encrypt=True;" +
                    $"TrustServerCertificate=False;" +
                    $"Connection Timeout=30;");
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
