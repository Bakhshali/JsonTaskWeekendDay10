using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace WeekendDay10Last
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee  = new Employee { Id = 1, Name = "Baxseli", Surname = "Nazarov", Age = 20 };
            Employee employee2 = new Employee { Id = 1, Name = "Kamal", Surname = "Abishli", Age = 19 };
            Employee employee3 = new Employee { Id = 1, Name = "Tural", Surname = "Hamidzade", Age = 18 };
            Employee employee4 = new Employee { Id = 1, Name = "Islam", Surname = "Khalitov", Age = 21 };

            Department department = new Department
            {
                Id = 1,
                employees = new List<Employee>()
                {
                    employee,
                    employee2,
                    employee3,
                    employee4,
                },
                Name = "CodeAcademy"             
            };

            var departSeri = JsonConvert.SerializeObject(department);
            
            using (StreamWriter sw = new StreamWriter(@"C:\Users\tu78rfrfu\source\repos\WeekendDay10Last\WeekendDay10Last\Datas\json1.json"))
            {
                sw.WriteLine(departSeri);
            }

            string result;

            using (StreamReader sr = new StreamReader(@"C:\Users\tu78rfrfu\source\repos\WeekendDay10Last\WeekendDay10Last\Datas\json1.json"))
            {
                result = sr.ReadLine();
            }

            Department depDeseri = JsonConvert.DeserializeObject<Department>(result);

            //Console.WriteLine(depDeseri.employees[0].Name);
            foreach (var item in depDeseri.employees)
            {
                Console.WriteLine(item.Name);
            }

            
        }
    }
}
