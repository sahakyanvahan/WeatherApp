using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<ICityService, CityService>();

var app = builder.Build();

app.MapGet("/test", () => "Hello worlds");
app.MapCityEndpoints();
// app.MapGet("/city", ([FromServices] ICityService cityService) => {
//     var city = cityService.GetCity();
//     return city;
// });

app.Run();