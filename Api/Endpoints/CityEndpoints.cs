using Microsoft.AspNetCore.Mvc;

public static class CiryEndpoints
{
    public static void MapCityEndpoints(this WebApplication app)
    {
        //app.MapGet("/city", () => GetCity);
        app.MapGet("/city", () => "GetCity");
    }

    public static IResult GetCity([FromServices]ICityService cityService)
    {
        //var city = cityService.GetCity();
        return Results.Ok("jdhaldhfaldhfb");
    }
}