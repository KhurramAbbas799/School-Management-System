using SchoolManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace SchoolManagementSystem.Controllers
{
    public class SubjectController : Controller
    {
        private readonly MyDbContext dbcontext;
        public SubjectController(MyDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        public IActionResult Index(Subject sub)
        {
            return View(sub);
        }
        [HttpPost]
        public IActionResult AddSubject(Subject obj)
        {
            if (obj.SubjectId == 0)
            {
                dbcontext.Subject.Add(obj);
                dbcontext.SaveChanges();
                return View("Index");
            }
            else
            {
                var subData = dbcontext.Subject.FirstOrDefault(x => x.SubjectId == obj.SubjectId);
                subData.SubjectName = obj.SubjectName;


                dbcontext.Subject.Update(subData);
                dbcontext.SaveChanges();
            }

            var c = dbcontext.Subject.ToList();
            return View("List", c);
        }

        public IActionResult List()
        {
            var subjectData = dbcontext.Subject.ToList();
            return View(subjectData);
        }

        public IActionResult Delete(int id)
        {

            var subjectData = dbcontext.Subject.Where(x => x.SubjectId == id).SingleOrDefault();
            dbcontext.Subject.Remove(subjectData);
            dbcontext.SaveChanges();

            var newSubjectData = dbcontext.Subject.ToList();
            return View("List", newSubjectData);
        }

    }
}