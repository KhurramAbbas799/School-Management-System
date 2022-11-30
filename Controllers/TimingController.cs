using SchoolManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace SchoolManagementSystem.Controllers
{
    public class TimingController : Controller
    {
        private readonly MyDbContext dbcontext;
        public TimingController(MyDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        public IActionResult Index(Timing tim)
        {
            return View(tim);
        }
        [HttpPost]
        public IActionResult AddTiming(Timing obj)
        {
            if (obj.TimingId == 0)
            {
                dbcontext.Timing.Add(obj);
                dbcontext.SaveChanges();
                return View("Index");
            }
            else
            {
                var timData = dbcontext.Timing.FirstOrDefault(x => x.TimingId == obj.TimingId);
                timData.TimingName=obj.TimingName;


                dbcontext.Timing.Update(timData);
                dbcontext.SaveChanges();
            }

            var c = dbcontext.Timing.ToList();
            return View("List", c);
        }

        public IActionResult List()
        {
            var timingData = dbcontext.Timing.ToList();
            return View(timingData);
        }

        public IActionResult Delete(int id)
        {

            var timingData = dbcontext.Timing.Where(x => x.TimingId == id).SingleOrDefault();
            dbcontext.Timing.Remove(timingData);
            dbcontext.SaveChanges();

            var newTimingData = dbcontext.Timing.ToList();
            return View("List", newTimingData);
        }

    }
}