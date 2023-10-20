using System;
using System.Collections.Generic;

namespace HTTPPOSTAPI.Models
{
    public partial class Employee
    {
        public int IdEmployee { get; set; }
        public string EmployeeName { get; set; } = null!;
        public int? Salary { get; set; }
        public int? CompanyId { get; set; }

        public virtual Company? Company { get; set; }
    }
}
