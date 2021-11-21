using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HRBAL1;
using HRDAL;
using System.Web.Http.Cors;

namespace HRServiceProject.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class EmpProjectController : ApiController
    {
        [HttpGet]
        public List<EmpProject> showdetails()
        {
            EmpProjectDAL d = new EmpProjectDAL();
            List<EmpProject> f = d.showdetails();
            return f;


        }
    }
}
