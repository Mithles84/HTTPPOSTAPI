using System;
using System.Collections.Generic;

namespace HTTPPOSTAPI.Models
{
    public partial class Company
    {
        public Company()
        {
            Employees = new HashSet<Employee>();
        }

        public int IdCompany { get; set; }
        public string CompanyName { get; set; } = null!;

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
