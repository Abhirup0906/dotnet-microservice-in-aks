using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetMSInAKS.Model.Response
{
    public class EmployeeBo
    {
        public int EmployeeId { get; set; }
        public string JobTitle { get; set; } = string.Empty;
        public DateOnly BirthDate { get; set; }
        public char MaritalStatus { get; set; }
        public char Gender { get; set; }
        public DateOnly HireDate { get; set; }
    }
}
