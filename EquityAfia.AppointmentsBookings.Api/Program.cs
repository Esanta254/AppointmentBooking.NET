
using EquityAfia.AppointmentsBookings.Api.Controllers;
using EquityAfia.AppointmentsBookings.Application.Services;
using EquityAfia.AppointmentsBookings.Contracts.Interfaces;

using EquityAfia.AppointmentsBookings.Domain.Interfaces;
using EquityAfia.AppointmentsBookings.Infrastructure.Data;
using EquityAfia.AppointmentsBookings.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DBCS"),
                         b => b.MigrationsAssembly("EquityAfia.AppointmentsBookings.Infrastructure")));

builder.Services.AddScoped<IAppointmentRepository, AppointmentRepository>();
builder.Services.AddScoped<AppointmentService>();
builder.Services.AddScoped<IAppointmentService, AppointmentService>();

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




