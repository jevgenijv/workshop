using Microsoft.AspNetCore.Mvc;
using WorkshopWebApi.Entity;
using WorkshopWebApi.Entity.Enums;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WorkshopWebApi.Controllers
{
    [Route("api/customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpGet("{id}")]
        public OutputCustomer Get(string id)
        {
            if (id == "5647")
            {
                return new OutputCustomer
                {
                    Id = "5647",
                    CustomerType = CustomerType.Private,
                    Birthday = "1996-05-12",
                    StreetName = "Gedimino pr. 10",
                    HouseNumber = "5",
                    Floor = "2",
                    Town = "Vilnius",
                    Country = Country.Lithuania,
                    PostalCode = "12357",
                    PersonalIdentification = "39605124789",
                    Gender = Gender.Male,
                    Name = "Vin",
                    LastName = "Diesel",
                    Title = "Mr.",
                };
            }

            return new OutputCustomer
            {
                Id = "5647",
                CustomerType = CustomerType.Private,
                Birthday = "1985-05-12",
                StreetName = "Paciuksenkatu 29",
                HouseNumber = "9",
                Floor = "3",
                Town = "Helsinki",
                Country = Country.Finland,
                PostalCode = "85478",
                PersonalIdentification = "4850512876",
                Gender = Gender.Female,
                Name = "Jennifer",
                LastName = "Lopez",
                Title = "Mrs."
            };
        }

        // POST api/<ValuesController>
        [HttpPost("save")]
        public ActionResult Save([FromBody] Customer customer)
        {
            return Ok();
        }
    }
}
