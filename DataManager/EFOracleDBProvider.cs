using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOLib;

namespace DataManager
{
    public class EFOracleDBProvider : IDBProvider
    {
        public List<DTO_Employee> GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        public DTO_Employee GetEmployeeByID(int EmployeeID)
        {
            throw new NotImplementedException();
        }
    }
}
