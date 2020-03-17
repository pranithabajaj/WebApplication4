using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class DBClass
    {

        static DemoEntities D = new DemoEntities();
        public static List<EMPDATA> getEmp()
        {
            var E = from E1 in D.EMPDATAs
                    select E1;
            return E.ToList(); 
        }
        public static EMPDATA getEmpdata(int eno)
        {
            var E = from E1 in D.EMPDATAs
                    where E1.EMPNO==eno
                    select E1;
            return E.First();
        }
    }
}