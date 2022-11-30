using SchoolManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace SchoolManagementSystem.Controllers
{
    public class SubjectTypeController : Controller
    {
        private readonly MyDbContext dbcontext;
        public SubjectTypeController(MyDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        public IActionResult Index(SubjectType st)
        {
            return View(st);
        }

        [HttpPost]
        public IActionResult AddSubjectType(SubjectType obj)
        {
            if (obj.SubjectTypeId == 0)
            {
                dbcontext.SubjectType.Add(obj);
                dbcontext.SaveChanges();
                return View("Index");
            }
            else
            {
                var stData = dbcontext.SubjectType.FirstOrDefault(x => x.SubjectTypeId == obj.SubjectTypeId);
                stData.SubjectTypeName = obj.SubjectTypeName;


                dbcontext.SubjectType.Update(stData);
                dbcontext.SaveChanges();
            }

            var c = dbcontext.SubjectType.ToList();
            return View("List", c);
        }

        public IActionResult List()
        {
            var subjectTypeData = dbcontext.SubjectType.ToList();
            return View(subjectTypeData);
        }
        public IActionResult Delete(int id)
        {

            var subjectTypeData = dbcontext.SubjectType.Where(x => x.SubjectTypeId == id).SingleOrDefault();
            dbcontext.SubjectType.Remove(subjectTypeData);
            dbcontext.SaveChanges();


            
      var newSubjectTypeData = dbcontext.SubjectType.ToList();
            return View("List", newSubjectTypeData);
        }

    }
}