using SchoolManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace SchoolManagementSystem.Controllers
{
    public class StudentController : Controller
    {
        private readonly MyDbContext dbcontext;
        public StudentController(MyDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        public IActionResult Index( Student stu)
        {
          return View(stu);
        }
        [HttpPost]
        public IActionResult AddStudent(Student obj)
        {

           if (obj.StudentId == 0)
            {
                dbcontext.Student.Add(obj);
                dbcontext.SaveChanges();
                return View("Index");
            }
        
            else
            {
                var stuData=dbcontext.Student.FirstOrDefault(x => x.StudentId == obj.StudentId);
                stuData.StudentName = obj.StudentName;
                stuData.StudentEmail = obj.StudentEmail;
                stuData.StudentAge= obj.StudentAge;
                stuData.StudentContact = obj.StudentContact;
                stuData.FatherName= obj.FatherName;
                stuData.Gender = obj.Gender;
                
               dbcontext.Student.Update(stuData);
                dbcontext.SaveChanges();
            }
           
            var c = dbcontext.Student.ToList();
            return View("List", c);
        }
        
        public IActionResult List()
        {
            var studentData = dbcontext.Student.ToList();
            return View(studentData);
        }
        public IActionResult Delete(int id)
        {

            var studentData = dbcontext.Student.Where(x => x.StudentId == id).SingleOrDefault();
            dbcontext.Student.Remove(studentData);
            dbcontext.SaveChanges();

            var newStudentData = dbcontext.Student.ToList();
            return View("List", newStudentData);
        }
    }
}