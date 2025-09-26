using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Practi4.Models;

namespace Practi4.Controllers
{
    public class EmpController : ApiController
    {
        msc1Entities db = new msc1Entities();
        // GET: api/Emp
        public IEnumerable<Table> Get()
        {
            return(db.Tables.ToList());
        }

        // GET: api/Emp/5
        public Table Get(int id)
        {
            return db.Tables.Find(id);
        }

        // POST: api/Emp
        public string Post([FromBody]Table et)
        {
            db.Tables.Add(et);
            db.SaveChanges();
            return "Data Added";
        }

        // PUT: api/Emp/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Emp/5
        public string Delete(int id)
        {
            Table et = db.Tables.Find(id);
            db.SaveChanges();
            return "Data Deleted";
        }
    }
}
