using SchoolManagementSystem.Models;

using Microsoft.AspNetCore.Mvc;

using SchoolManagementSystem.DTO;
using System.Reflection.Metadata.Ecma335;
using System.Linq;
using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Controllers
{
    public class RiderController : Controller
    
    {
        private readonly MyDbContext dbcontext;
        
        public RiderController(MyDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }
        
        public IActionResult Index(Dto edit)
        {
            return View(edit);
        }

        public  IActionResult AddRider(Dto obj)
        {
            if (obj.RiderId == 0)
            {
                var userData = new User();

                userData.UserName = obj.FirstName + obj.LastName;
                userData.Password = obj.Password;
                userData.Email = obj.Email;
                userData.CNIC = obj.CNIC;

                dbcontext.User.Add(userData);
                dbcontext.SaveChanges();

            

                var riderData = new Rider();

                riderData.FirstName = obj.FirstName;
                riderData.LastName = obj.LastName;
                riderData.Email = obj.Email;
                riderData.Contact = obj.Contact;
                riderData.CNIC = obj.CNIC;
                riderData.Address = obj.Address;
                riderData.TransportType = obj.TransportType;


                riderData.UserId = userData.UserId;
                dbcontext.Rider.Add(riderData);
                dbcontext.SaveChanges();

                return RedirectToAction("List");
                //return View("Index");
            }

            else
            {


                var newRiderData = dbcontext.Rider.FirstOrDefault(x => x.RiderId == obj.RiderId);
                newRiderData.FirstName = obj.FirstName;
                newRiderData.LastName = obj.LastName;
                newRiderData.Email = obj.Email;
                newRiderData.Contact = obj.Email;
                newRiderData.CNIC = obj.CNIC;
                newRiderData.Address = obj.Address;
                newRiderData.TransportType = obj.TransportType;


                var newUserData = dbcontext.User.FirstOrDefault(x => x.UserId == newRiderData.UserId);

                newUserData.UserName = obj.FirstName + obj.LastName;
                newUserData.Password = obj.Password;
                newUserData.Email = obj.Email;
                newUserData.CNIC = obj.CNIC;

               
                dbcontext.Rider.Update(newRiderData);
                dbcontext.User.Update(newUserData);
                dbcontext.SaveChanges();
                
            }
            return RedirectToAction("List");
            //var c = dbcontext.Dto.ToList();
            //return View("List", c);
           
        }

        [HttpGet]
        public IActionResult List()
        {
            var model =  (from a in dbcontext.Rider              
                         join b in dbcontext.User             
                         on a.UserId equals b.UserId
                         
                         select new Dto
                         {
                            RiderId=a.RiderId,
                             FirstName = a.FirstName,
                             LastName = a.LastName,
                             Email = a.Email,
                             Contact = a.Contact,
                             CNIC = a.CNIC,
                             Address = a.Address,
                             TransportType = a.TransportType,
                              
                             UserId = a.UserId,

                             UserName = b.UserName,
                             Password = b.Password,
                            

                         }).ToList();
            return View(model);
        }

        public IActionResult Delete(int id)
        
        {

            var riderData = dbcontext.Rider.Where(x => x.RiderId == id).SingleOrDefault();
          
            var userData = dbcontext.User.Where(x => x.UserId == riderData.UserId).SingleOrDefault();
            
            dbcontext.Rider.Remove(riderData);
            dbcontext.User.Remove(userData);
            dbcontext.SaveChanges();

            return RedirectToAction("List");
            //var newClassData = dbcontext.Dto.ToList();
            //return View("List", newClassData);
        }

    }


}


