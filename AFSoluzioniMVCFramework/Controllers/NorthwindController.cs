using AFSoluzioniMVCFramework.Extensions;
using DataManager;
using DTOLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AFSoluzioniMVCFramework.Controllers
{

    public class NorthwindController : Controller
    {
        private IDBProvider db;
       //public NorthwindController() 
        public NorthwindController(IDBProvider db) // dependency
        {
            String s = "999111";
            bool isNum = s.IsNumeric();
            //db = new ADODBProvider();
            //db = FactoryDBProvider.GetProvider();

            this.db = db; // injection
        }
        [Authorize]
        // GET: Northwind
        public ActionResult Employees()
        {
            Session["myObject"] = new DTO_Employee() {FirstName="lkj" };

            List<DTO_Employee> model = db.GetAllEmployees();
            return View(model);
        }

        public ActionResult Details(int id)
        {
            DTO_Employee model = db.GetEmployeeByID(id);
            return View(model);
        }

        public ActionResult Create()
        {
            var z = SyncMethod();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(DTO_Employee model)
        {
            //.....................

            var x = await AsyncMethod();

            //var z = SyncMethod();

            OperationResult result = db.NewEmployee(model);
            return View();
        }

        private object SyncMethod()
        {
            throw new NotImplementedException();
        }

        private Task<int> AsyncMethod()
        {
            throw new NotImplementedException();
        }
    }
}