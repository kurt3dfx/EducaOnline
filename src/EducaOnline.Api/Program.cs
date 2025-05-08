using EducaOnline.Conteudo.Application.AutoMapper;
using EducaOnline.Conteudo.Data;
using EducaOnline.WebApp.MVC.Setup;
using MediatR;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "EducaOnline API",
        Version = "v1",
        Contact = new Microsoft.OpenApi.Models.OpenApiContact
        {
            Name = "Educa Online Suporte",
            Email = "tjmbbr@gmail.com",
            //Url = new Uri("https://screensound.com/support")
        }
    });
});

builder.Services.AddDbContext<ConteudoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddAutoMapper(typeof(DomainToViewModelMappingProfile), typeof(ViewModeltoDomainMappingProfile));
builder.Services.AddMediatR(typeof(Program));

builder.Services.RegisterService();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(
        c => c.OpenApiVersion = Microsoft.OpenApi.OpenApiSpecVersion.OpenApi2_0
    );
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("../swagger/v1/swagger.json", "EducaOnline API v1"); 
    });
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
