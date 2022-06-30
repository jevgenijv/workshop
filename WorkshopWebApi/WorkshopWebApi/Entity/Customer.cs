using WorkshopWebApi.Entity.Enums;

namespace WorkshopWebApi.Entity;

public class Customer
{
    public string Id { get; set; }
    public string ExternalId { get; set; }
    public CustomerType CustomerType { get; set; }
    public DateTime Birthday { get; set; }
    public Address Address { get; set; }
    public PersonalDetails PersonalDetails { get; set; }
}
