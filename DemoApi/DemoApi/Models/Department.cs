using System.Collections;
using System.Collections.Generic;

namespace DemoApi.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Navigation Properties
        public List<Employee> Employees { get; set; }
    }
}