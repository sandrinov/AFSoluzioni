using AFSoluzioniMVCCoreAuth.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AFSoluzioniMVCCoreAuth.Controllers
{
    public class APIController : Controller
    {
        private DBManager db;
        public APIController()
        {
            db = new DBManager();
        }
        public JsonResult GetAllEmployees()
        {
            return Json(db.GetAllEmployees());
        }
    }
}
