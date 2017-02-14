using DAL.Repository;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace CompAssessment.Controllers
{
    public class StudentApiController : ApiController
    {
        [HttpPost]
        [Route("/Student/Insert")]
        public JsonResult InsertStudent(Student student)
        {
            Repository<Student> repo = new Repository<Student>();
            var result = repo.InsertOrUpdate(student);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}
