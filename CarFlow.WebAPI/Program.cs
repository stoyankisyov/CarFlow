using CarFlow.Core.Models.Settings;
using CarFlow.Infrastructure.Models;
using CarFlow.WebAPI.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace CarFlow.WebAPI;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddDbContext<CarFlowContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("SQLConnection") ??
                                 throw new InvalidOperationException(
                                     "Connection string 'SQLConnection' not found.")));

        builder.Services.Configure<JwtSettings>(builder.Configuration.GetSection("JwtSettings"));
        builder.Services.AddSingleton(serviceProvider =>
            serviceProvider.GetRequiredService<IOptions<JwtSettings>>().Value);

        builder.Services.AddJwtAuthentication(builder.Configuration);
        builder.Services.AddPolicyAuthorization();

        builder.Services.AddControllers();

        builder.Services.AddSwaggerWithJwt();
        builder.Services.AddEndpointsApiExplorer();

        builder.Services.AddRepositories();
        builder.Services.AddDomainServices();
        builder.Services.AddDomainHandlers();
        builder.Services.AddDomainFactories();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthentication();
        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}