using Microsoft.EntityFrameworkCore;
using Test.API.Data;

namespace Test.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            var services = builder.Services;
            // Add services to the container.

            services.AddDbContext<AppDbContext>(x => x.UseSqlServer(
                builder.Configuration.GetConnectionString("DatabaseConn")));

            builder.Services.AddControllers();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}