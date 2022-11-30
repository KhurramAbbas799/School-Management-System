using SchoolManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace SchoolManagementSystem.Controllers
{
    public class ClassController : Controller
    {
        private readonly MyDbContext dbcontext;
        public ClassController(MyDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        public IActionResult Index(Class cl)
        {
            return View(cl);
        }
        [HttpPost]
        public IActionResult AddClass(Class obj)
        {
            if (obj.ClassId == 0)
            {
                dbcontext.Class.Add(obj);
                dbcontext.SaveChanges();
                return View("Index");
            }
            else
            {
                var classData=dbcontext.Class.FirstOrDefault(x => x.ClassId == obj.ClassId);
                
                classData.ClassName = obj.ClassName;

                dbcontext.Class.Update(classData);
                dbcontext.SaveChanges();
            }
            var c = dbcontext.Class.ToList();
            return View("List", c);

        }
        public IActionResult List()
        {
            var classData = dbcontext.Class.ToList();
            return View(classData);
        }

        public IActionResult Delete(int id)
        {

            var classData = dbcontext.Class.Where(x => x.ClassId == id).SingleOrDefault();
            dbcontext.Class.Remove(classData);
            dbcontext.SaveChanges();

            var newClassData = dbcontext.Class.ToList();
            return View("List", newClassData);
        }


    }
}