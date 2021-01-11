using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLib
{
    public class DTO_Employee
    {
        [DisplayName("ID")]
        public int ID { get; set; }
        [DisplayName("Nome")]
        public String FirstName { get; set; }
        [DisplayName("Cognome")]
        //[Required]
        //[RegularExpression("jlkjlkj")]
        public String LastName { get; set; }
        [DisplayName("Data Assunzione")]
        public DateTime HireDate { get; set; }
    }
}
