using DTOLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager
{
    public interface IDBProvider
    {
        List<DTO_Employee> GetAllEmployees();
        DTO_Employee GetEmployeeByID(int EmployeeID);
    }
}
