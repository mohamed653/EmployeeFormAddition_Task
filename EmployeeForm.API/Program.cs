using EmployeeForm.BLL.IServices;
using EmployeeForm.BLL.Service;
using EmployeeForm.DAL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

// Adding OpenAPI documentation
var webHostEnvironment = builder.Services.BuildServiceProvider().GetRequiredService<IWebHostEnvironment>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Employee Form Addition API",
        Version = "v1",
        Description = "Employee Form Addition Using ASP.NET Core Web API",
        Contact = new OpenApiContact
        {
            Name = "Mohamed_Hamed",
            Email = "mohamedHamed@gmail.com"
        }

    });
    //c.IncludeXmlComments(webHostEnvironment.WebRootPath + "\\mydoc.xml");
});


// Adding the DbContext to the DI container
builder.Services.AddDbContext<EmployeeContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Adding the EmployeeService to the DI container
builder.Services.AddScoped<IEmployeeService, EmployeeService>();





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
