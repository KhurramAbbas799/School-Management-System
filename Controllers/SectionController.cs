using SchoolManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace SchoolManagementSystem.Controllers
{
    public class SectionController : Controller
    {
        private readonly MyDbContext dbcontext;
        public SectionController(MyDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        public IActionResult Index(Section sec)
        {
            return View(sec);
        }
        [HttpPost]
        public IActionResult AddSection(Section obj)
        {
            if (obj.SectionId==0)
            {
                dbcontext.Section.Add(obj);
                dbcontext.SaveChanges();
                return View("Index");
            }
            else
            {
                var secData = dbcontext.Section.FirstOrDefault(x => x.SectionId == obj.SectionId);
                secData.SectionName = obj.SectionName;
               

                dbcontext.Section.Update(secData);
                dbcontext.SaveChanges();
            }

            var c = dbcontext.Section.ToList();
            return View("List", c);
        }
        public IActionResult List()
        {
            var sectionData = dbcontext.Section.ToList();
            return View(sectionData);
        }

        public IActionResult Delete(int id)
        {

            var SectionData = dbcontext.Section.Where(x => x.SectionId == id).SingleOrDefault();
            dbcontext.Section.Remove(SectionData);
            dbcontext.SaveChanges();

            var newSectionData = dbcontext.Section.ToList();
            return View("List", newSectionData);
        }


    }
}