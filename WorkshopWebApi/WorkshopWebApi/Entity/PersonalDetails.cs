using WorkshopWebApi.Entity.Enums;

namespace WorkshopWebApi.Entity;

public class PersonalDetails
{
    public string PersonalIdentification { get; set; }
    public Gender Gender { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Title { get; set; }
    public string FullName { get; set; }
}
