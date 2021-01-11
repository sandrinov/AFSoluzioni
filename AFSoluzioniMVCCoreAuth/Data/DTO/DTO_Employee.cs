using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AFSoluzioniMVCCoreAuth.Data.EF;

namespace AFSoluzioniMVCCoreAuth.Data.DTO
{
    public class DTO_Employee
    {
        private Employees item;

        public DTO_Employee(Employees item)
        {
            EmployeeId = item.EmployeeId;
            LastName = item.LastName;
            FirstName = item.FirstName;
            BirthDate = item.BirthDate.HasValue ? item.BirthDate.Value : DateTime.Now;
        }

        public int EmployeeId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
