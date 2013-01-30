using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class Customer
    {
        public string  Name { get; set; }
    }

    public class HomeController : Controller
    {

        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetCustomers(int Id)
        {
            List<Customer> customers= new List<Customer>(){
                new Customer(){Name="Vishal"}
            };
            return Json(customers);
        }

    }
}
