using Microsoft.EntityFrameworkCore;
using OfficeBookingBLL.Services;
using OfficeSeatBookingDAL;
using OfficeSeatBookingDAL.Repost;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddScoped<EmployeeService, EmployeeService>();
builder.Services.AddScoped<IEmployeeRepost, EmployeeRepost>();

builder.Services.AddDbContext<OfficeDbContext>(option => {
    option.UseSqlServer(builder.Configuration.GetConnectionString("sqlConnection"));
});
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

app.UseAuthorization();

app.MapControllers();

app.Run();
