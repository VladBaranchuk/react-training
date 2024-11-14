using back_end.DataAccess;
using back_end.DataAccess.Providers;
using back_end.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;

namespace back_end
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContextPool<DatabaseContext>(options =>
            {
                options.UseSqlServer("Server=.; Initial Catalog=ReactTraining; Trusted_Connection=True; TrustServerCertificate=True");
            });
            builder.Services.AddScoped<ProfileProvider>();
            builder.Services.AddScoped<ProfileRepository>();

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("Development", builder =>
                    builder
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .SetIsOriginAllowed(origin => true)
                    .AllowCredentials());
            });

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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

            app.UseCors("Development");
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
