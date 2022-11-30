using SchoolManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace SchoolManagementSystem.Controllers
{
    public class SessionController : Controller
    {
        private readonly MyDbContext dbcontext;
        public SessionController(MyDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        public IActionResult Index(Session sess)
        {
            return View(sess);
        }
        [HttpPost]
        public IActionResult AddSession(Session obj)
        {
            if (obj.SessionId == 0)
            {
                dbcontext.Session.Add(obj);
                dbcontext.SaveChanges();
                return View("Index");
            }
            else
            {
                var sessData = dbcontext.Session.FirstOrDefault(x => x.SessionId == obj.SessionId);
                sessData.SessionName = obj.SessionName;


                dbcontext.Session.Update(sessData);
                dbcontext.SaveChanges();
            }

            var c = dbcontext.Session.ToList();
            return View("List", c);
        }

        public IActionResult List()
        {
            var sessionData = dbcontext.Session.ToList();
            return View(sessionData);
        }

        public IActionResult Delete(int id)
        {

            var sessionData = dbcontext.Session.Where(x => x.SessionId == id).SingleOrDefault();
            dbcontext.Session.Remove(sessionData);
            dbcontext.SaveChanges();

            var newSessionData = dbcontext.Teacher.ToList();
            return View("List", newSessionData);
        }


    }
}