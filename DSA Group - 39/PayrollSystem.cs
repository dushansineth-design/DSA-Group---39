using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Group___39
{
    class PayrollSystem
    {
        public double CalculateSalary(int attendance, Employee emp)
        {
            double salary = emp.BasicSalary;

           
            if (emp.ServiceTime > 10)
            {                
                salary *= 1.5;
            }

            double basicS = salary;


            if (attendance <= 30)
            {
                salary = (salary * attendance) / 20;
            }
            if (attendance == 30)
            {
                salary = (basicS*0.05 + salary);
            }

            if (attendance > 30)
            {      
                salary = 0;
            }    

            return salary;
        }
    }
}
