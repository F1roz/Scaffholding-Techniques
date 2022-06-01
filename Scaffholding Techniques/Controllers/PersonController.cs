using Scaffholding_Techniques.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Scaffholding_Techniques.Controllers
{
    public class PersonController : Controller
    {
        List<Person> persons = new List<Person>()
        {
            new Person() {Id=1, Name= "Firoz", Email="firoz@gmail.com",Salary= 5000},
            new Person() {Id=2, Name= "Fahim", Email="fahim@gmail.com",Salary= 15000},
            new Person() {Id=3, Name= "Ahmed", Email="Ahmed@gmail.com",Salary= 25000}
        };
        public ActionResult Index()
        {
            return View(persons);
        }
    }
}