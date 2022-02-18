using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplyeeWageCompute
{
    public class EmployeeWageCompute
    {

        public static void EmpWageCal()
        {
            int WagePerHour = 20;
            int FullDayWage = 8;
            
            Random random = new Random();
            int num = random.Next(2);

            if (num == 1)
            {
                float Calculate = (WagePerHour * FullDayWage);
                Console.WriteLine("Per Day Wage" +Calculate);

            }
            
            else
            {

                int Calculate= 0;

                Console.WriteLine("PerDay Wage" + Calculate);
            }
        }
    }
}

