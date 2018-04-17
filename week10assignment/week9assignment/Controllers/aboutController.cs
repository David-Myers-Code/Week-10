using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using week9assignment.Models;
using week9assignment.Controllers;


namespace week9assignment.Controllers
{

    


    public class aboutController : Controller
    {
        /*static List<Employee> employees = new List<Employee>()
    {
        new Employee()
        {
            Name = "Harvey Dixon",
            UrlPath = "dixon",
            Bio = "I like movies, reading books and tea. I also listen to a lot of podcasts.",
            PhotoUrl = "/assets/images/employees/dixon.jpg"
        },
        new Employee()
        {
            Name = "Bobby Fuller",
            UrlPath = "fuller",
            Bio = "Originally from New York City. Sports and music enthusiast.",
            PhotoUrl = "/assets/images/employees/fuller.jpg"
        },
        new Employee()
        {
            Name = "Lauren Kelly",
            UrlPath = "kelly",
            Bio = "I have a passion for architecture. Always eager to learn new things.",
            PhotoUrl = "/assets/images/employees/kelly.jpg"
        },
        new Employee()
        {
            Name = "Jeremy Miller",
            UrlPath = "miller",
            Bio = "I'm passionate about music and cooking. Also my dog is named after a Superhero.",
            PhotoUrl = "/assets/images/employees/miller.jpg"
        },
        new Employee()
        {
            Name = "Eva Russell",
            UrlPath = "russell",
            Bio = "Avid consumer of chocolate. I also like running, horror movies and my puppy.",
            PhotoUrl = "/assets/images/employees/russell.jpg"
        }


    };
    */

        private EmployeesContext db = new EmployeesContext();

        // GET: about
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Profile(string name)
        {

            //Employee employee = employees.First(e => e.UrlPath == name);
           var employee = db.Employees.First(e => e.UrlPath == name);

            return View(employee);
        }
        [ChildActionOnly]
        public ActionResult EmployeeList()
        {
            List<Employee> employees = db.Employees.ToList();

            return PartialView(employees);
        }

        
    }
}