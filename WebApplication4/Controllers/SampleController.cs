using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class SampleController : Controller
    {
        // GET: Sample
        public ActionResult Index()
        {
            List<EMPDATA>L=   DBClass.getEmp();

            return View(L);
        }
        public ActionResult ExtractEmp()
        {
            int Eno = int.Parse(Request.Form["rdbEmp"].ToString());
            EMPDATA E = DBClass.getEmpdata(Eno);
            return View(E);
        }
        public ActionResult Index1()
        {
            ViewBag.L = DBClass.getEmp();

            return View();
        }
        public ActionResult ExtractEmp1()
        {
            int Eno = int.Parse(Request.Form["rdbEmp"].ToString());
            ViewBag.E = DBClass.getEmpdata(Eno);
            return View();
        }
        public ActionResult Index2()
        {
            List<EMPDATA> L = DBClass.getEmp();

            return View(L);
        }
        public ActionResult ExtractEmp2()
        {
            int Eno = int.Parse(Request.QueryString["E"].ToString());
            EMPDATA E = DBClass.getEmpdata(Eno);
            return View(E);
        }
    }
}