using System;
using System.Collections.Generic;
using System.Text;

namespace WeekendDay10Last
{
    class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Employee> employees { get; set; } = new List<Employee>();
    }
}
