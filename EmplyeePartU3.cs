using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplyeeAddPartTimeUC3;

    public class EmplyeePartU3
    {
        public static void EmpUC3()
        {
        int partTime = 1;

        int FullTime = 2;

        int Emp_Wage_Hour = 20;

        int emphrs = 0;

        Random random = new Random();

        int num = random.Next(3);

        if (num==partTime)
        {
            emphrs = 4;
        }

        else if(num==FullTime)
        {
            emphrs = 8;
        }

        else
        {
            emphrs = 0;
        }

        int Cal = Emp_Wage_Hour * emphrs;

        Console.WriteLine("per day wage" + Cal);


        }
    }

