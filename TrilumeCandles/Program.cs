using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using TrilumeCandles.Areas.Identity.Data;
using TrilumeCandles.Data;

namespace TrilumeCandles
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<TrilumeCandlesContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("TrilumeCandlesContext") ?? throw new InvalidOperationException("Connection string 'TrilumeCandlesContext' not found.")));

            builder.Services.AddDbContext<TrilumeCandlesIdentity>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("TrilumeCandlesContext") ?? throw new InvalidOperationException("Connection string 'TrilumeCandlesIdentityConnection' not found.")));

            builder.Services.AddDefaultIdentity<TrilumeCandlesUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<TrilumeCandlesIdentity>();


            // Add services to the container.
            builder.Services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
                options.JsonSerializerOptions.WriteIndented = true;
            });

            builder.Services.AddOpenApi();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
