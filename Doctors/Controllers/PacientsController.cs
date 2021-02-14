using Doctors.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Doctors.Controllers
{
    public class PacientsController : ApiController
    {
        // GET: api/Pacients
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Pacients/5
        public List<Pacient> Get(int id)
        {
            var repo = new PacientsRepository();
            List<Pacient> pacients = repo.RetrieveByDoctorId(id);
            return pacients;
        }

        // POST: api/Pacients
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Pacients/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Pacients/5
        public void Delete(int id)
        {
        }
    }
}
