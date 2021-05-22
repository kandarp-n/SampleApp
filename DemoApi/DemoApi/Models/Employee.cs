using System.ComponentModel.DataAnnotations.Schema;

namespace DemoApi.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Navigation properties
        public int Dept { get; set; }

        public Department Department { get; set; }
    }
}