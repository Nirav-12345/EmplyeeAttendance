using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePartTimeUsingSwitch;

    public class EmployeePartSwich
    {
        public const int PartTime = 1;
        public const int FullTime = 2;
        public const int WageHour = 20;

        

        public static void EmpPartUsingSwi()
        {
            Random random = new Random();
            int num = random.Next(3);
            int Emphrs = 0;
            switch (num)
            {
                case PartTime:
                    Emphrs = 4;
                    break;

                case FullTime:
                    Emphrs = 8;
                    break;

                default:
                    Emphrs=0;
                    break;
            }

            int Cal = WageHour * Emphrs;

            Console.WriteLine("Per dayage" + Cal);
        }
    }

