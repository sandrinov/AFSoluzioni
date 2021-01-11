using AFSoluzioniMVCCoreAuth.Data.DTO;
using AFSoluzioniMVCCoreAuth.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AFSoluzioniMVCCoreAuth.Data
{
    public class DBManager
    {
        private NorthwindContext ctx;
        public DBManager()
        {
            ctx = new NorthwindContext();
        }

        public List<DTO_Employee> GetAllEmployees()
        {
            List<DTO_Employee> res_list = new List<DTO_Employee>();
            var ef_employees = ctx.Employees.ToList();
            foreach (var item in ef_employees)
            {
                res_list.Add(new DTO_Employee(item));
            }
            return res_list;
        }
    }
}
