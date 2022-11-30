using SchoolManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace SchoolManagementSystem.Controllers
{
    public class TeacherController : Controller
    {
        private readonly MyDbContext dbcontext;
        public TeacherController(MyDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        public IActionResult Index(Teacher tea)
        {
            return View(tea);
        }
        [HttpPost]
        public IActionResult AddTeacher(Teacher obj)
        {
            if (obj.TeacherId == 0)
            {
                dbcontext.Teacher.Add(obj);
                dbcontext.SaveChanges();
                return View("Index");
            }
            else
            {
                var teaData = dbcontext.Teacher.FirstOrDefault(x => x.TeacherId == obj.TeacherId);
                teaData.TeacherName = obj.TeacherName;
                teaData.TeacherEmail=obj.TeacherEmail;
                teaData.TeacherGender = obj.TeacherGender;
                teaData.TeacherContact = obj.TeacherContact;


                dbcontext.Teacher.Update(teaData);
                dbcontext.SaveChanges();
            }

            var c = dbcontext.Teacher.ToList();
            return View("List", c);
        }

        public IActionResult List()
        {
            var teacherData = dbcontext.Teacher.ToList();
            return View(teacherData);
        }

        public IActionResult Delete(int id)
        {

            var teacherData = dbcontext.Teacher.Where(x => x.TeacherId == id).SingleOrDefault();
            dbcontext.Teacher.Remove(teacherData);
            dbcontext.SaveChanges();

            var newTeacherData = dbcontext.Teacher.ToList();
            return View("List", newTeacherData);
        }
    }
}