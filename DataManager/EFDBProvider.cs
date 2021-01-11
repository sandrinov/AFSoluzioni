using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataManager.EF;
using DTOLib;

namespace DataManager
{
    public class EFDBProvider : IDBProvider
    {
        private NorthwindEntities ctx;
        public EFDBProvider()
        {
            this.ctx = new NorthwindEntities();
        }

        public List<DTO_Employee> GetAllEmployees()
        {
            List<DTO_Employee> resultList = new List<DTO_Employee>();
            //List<Employee> employees = ctx.Employees.ToList();

            var query = from e in ctx.Employees
                        orderby e.LastName
                        select e;

            List<Employee> employees = query.ToList();

            Employee emp1 = new Employee() { FirstName = "aaa", LastName = "bbb" };
            Employee emp2 = new Employee() { FirstName = "aaa", LastName = "bbb" };
            Employee emp3 = new Employee() { FirstName = "aaa", LastName = "bbb" };
            Employee emp4 = new Employee() { FirstName = "aaa", LastName = "bbb" };

            foreach (var item in employees)
            {
                resultList.Add(new DTO_Employee() {
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    HireDate = item.HireDate.HasValue ? item.HireDate.Value : DateTime.Now,
                    ID = item.EmployeeID
                });
            }
            return resultList;
        }

        public DTO_Employee GetEmployeeByID(int EmployeeID)
        {
            DTO_Employee result = null;          
            var query = from e in ctx.Employees
                        where e.EmployeeID == EmployeeID
                        select e;
            return result;
        }

        public OperationResult NewEmployee(DTO_Employee dto_emp)
        {
            OperationResult res = new OperationResult() { IsOperationOK = true };
            Employee ef_emp = new Employee()
            {
                FirstName = dto_emp.FirstName,
                LastName = dto_emp.LastName,
                HireDate = dto_emp.HireDate
            };

            ctx.Employees.Add(ef_emp);
            try
            {
                ctx.SaveChanges();
            }
            catch (Exception excp)
            {
                res.IsOperationOK = false;
                res.Message = excp.Message;
            }
            return res;
        }
    }
}
