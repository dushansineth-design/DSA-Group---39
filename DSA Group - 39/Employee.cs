using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Group___39
{
    
          

class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public int ServiceTime { get; set; }
        public int Position { get; set; }  // 1 - Normal, 2 - Supervisor, 3 - Asst. Manager, 4 - Manager
        public double BasicSalary { get; set; }

        public Employee(int id, string name, string telephone, int serviceTime, int position, double basicSalary)
        {
            ID = id;
            Name = name;
            Telephone = telephone;
            ServiceTime = serviceTime;
            Position = position;
            BasicSalary = basicSalary;
        }
    }
    
}


