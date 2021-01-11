using DTOLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager
{
    public class TestDBProvider : IDBProvider
    {
        public List<DTO_Employee> GetAllEmployees()
        {
            List<DTO_Employee> resultlist = new List<DTO_Employee>()
            {
                new DTO_Employee(){ID=1, FirstName="Mario", LastName="Rossi", HireDate = DateTime.Now},
                new DTO_Employee(){ID=1, FirstName="Maria", LastName="Rossi", HireDate = DateTime.Now}
            };
            return resultlist;
        }
        public DTO_Employee GetEmployeeByID(int EmployeeID)
        {
            return new DTO_Employee() { ID = 1, FirstName = "Mario", LastName = "Rossi", HireDate = DateTime.Now };
        }

        public OperationResult NewEmployee(DTO_Employee model)
        {
            throw new NotImplementedException();
        }
    }
}
