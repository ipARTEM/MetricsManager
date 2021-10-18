using AutoMapper;
using Core;
using FluentMigrator.Runner;
using MetricsAgent.DAL;
using MetricsAgent.Models;
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
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsAgent
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

            services.AddDbContext<AppDbContext>(options =>
            options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")));

            //ConfigureSqlLiteConnection(services);
            //services.AddScoped<ICpuMetricsRepository, CpuMetricsRepository>();
            services.AddTransient<INotifier, Notifier1>();
            services.AddTransient<INotifierMediatorService, NotifierMediatorService>();

            var mapperConfiguration = new MapperConfiguration(mp => mp.AddProfile(new MapperProfile()));
            var mapper = mapperConfiguration.CreateMapper();
            services.AddSingleton(mapper);





            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MetricsAgent", Version = "v1" });
            });
        }

        //private void ConfigureSqlLiteConnection(IServiceCollection services)
        //{
        //    const string connectionString = "Data Source=metrics.db;Version=3;Pooling=true;Max Pool Size=100;";
        //    var connection = new SQLiteConnection(connectionString);
        //    connection.Open();
        //    PrepareSchema(connection);
        //}

        //private void PrepareSchema(SQLiteConnection connection)
        //{
        //    using (var command = new SQLiteCommand(connection))
        //    {
        //        // задаем новый текст команды для выполнения
        //        // удаляем таблицу с метриками если она существует в базе данных
        //        command.CommandText = "DROP TABLE IF EXISTS cpumetrics";
        //        // отправляем запрос в базу данных
        //        command.ExecuteNonQuery();


        //        command.CommandText = @"CREATE TABLE cpumetrics(id INTEGER PRIMARY KEY,
        //            value INT, time INT)";
        //        command.ExecuteNonQuery();
        //    }
        //}



        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env
            //, IMigrationRunner migrationRunner
            )
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MetricsAgent v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            // запускаем миграции
            //migrationRunner.MigrateUp();

        }
    }
}
