using WorkshopWebApi.Entity.Enums;

namespace WorkshopWebApi.Entity;

public class OutputCustomer
{
    public string Id { get; set; }
    public CustomerType CustomerType { get; set; }
    public string Birthday { get; set; }
    public string StreetName { get; set; }
    public string HouseNumber { get; set; }
    public string Floor { get; set; }
    public string Town { get; set; }
    public Country Country { get; set; }
    public string PostalCode { get; set; }
    public string PersonalIdentification { get; set; }
    public Gender Gender { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Title { get; set; }
}
