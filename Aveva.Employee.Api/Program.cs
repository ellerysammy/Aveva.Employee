using Aveva.Employee.Api.Configurations;
using Aveva.Employee.Common;

var builder = WebApplication.CreateBuilder(args);
var _appSettings = builder.Configuration;
var _authSettings = builder.Configuration.GetSection(typeof(AuthSettings).Name).Get<AuthSettings>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.ConfigureDbContext(_appSettings)
                .ConfigureAuthentication(_authSettings)
                .ConfigureMappings()
                .ConfigureRepos()
                .ConfigureServices()
                .AddHttpContextAccessor();

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
