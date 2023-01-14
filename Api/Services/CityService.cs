public class CityService : ICityService
{
    public City GetCity()
    {
        return new City()
        {
            Id = 1,
            Name = "Yerevan-new",
        };
    }
}