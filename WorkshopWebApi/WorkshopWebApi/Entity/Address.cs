using WorkshopWebApi.Entity.Enums;

namespace WorkshopWebApi.Entity;

public class Address
{
    public string StreetName { get; set; }
    public string HouseNumber { get; set; }
    public string Floor { get; set; }
    public string Town { get; set; }
    public Country Country { get; set; }
    public string PostalCode { get; set; }
}