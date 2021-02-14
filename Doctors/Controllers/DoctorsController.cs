using Doctors.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Doctors.Controllers
{
   
    public class DoctorsController : ApiController
    {
        // GET: api/Doctors
       
        public IEnumerable<Doctor> Get()
        {
            var repo = new DoctorsRepository();
            List<Doctor> doctors = repo.Retrieve();
            return doctors;
        }

        // GET: api/Doctors/5
        public Doctor Get(int id)
        {
            /*var repo = new DoctorsRepository();
            Doctor d = repo.Retrieve();
            return d;*/
            return null;
        }

        // POST: api/Doctors
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Doctors/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Doctors/5
        public void Delete(int id)
        {
        }
    }
}
