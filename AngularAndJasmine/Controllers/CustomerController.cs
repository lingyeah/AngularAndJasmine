using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AngularAndJasmine.Models;

namespace AngularAndJasmine.Controllers
{
    public class CustomerController : ApiController
    {
        private List<Customer> _allCustomers = new List<Customer>()
        {
            new Customer() {
                Id = 1,
                FirstName = "Ling",
                LastName = "Chang",
                Age = 43
            },
            new Customer() {
                Id = 2,
                FirstName = "Suzanne",
                LastName = "Lui",
                Age = 42
            },
             new Customer() {
                Id = 3,
                FirstName = "KitYung",
                LastName = "Tam",
                Age = 79
            },
        };

        // GET api/values
        public IHttpActionResult Get()
        {
            return Ok(_allCustomers);
        }

        // GET api/values/5
        public IHttpActionResult Get(int id)
        {
            Customer matchedCust = _allCustomers.Where(c => c.Id == id).FirstOrDefault();

            if (matchedCust == null)
                return NotFound();

            return Ok(matchedCust);
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
