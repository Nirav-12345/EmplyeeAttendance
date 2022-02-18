using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplyeePresent
{
    public class EmplyeeAttendance
    {
        public static void EmpPresentOrNot()
        {
            Random random = new Random();
            int number = random.Next(2);

            if (number==1)

            {
                Console.WriteLine("Employee Present");




            }

            else
            {
                Console.WriteLine("Employee Absent");
            }
        }
    }
}
