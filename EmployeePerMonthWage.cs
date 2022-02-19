using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMonthWage;

public class EmployeePerMonthWage
{
    public const int PartTime = 1;

    public const int FullTime = 2;

    public const int empRatePerHr = 20;

    public const int numofworkingdays = 20;

    public static void EmpPerMonWag()
    {

        int Emphrs=0;
        int totalsalary = 0;

        

        for (int day = 1; day <= numofworkingdays; day++)
        {

            Random random = new Random();
            int num = random.Next(3);


            switch (num)
            {
                case PartTime:
                     Emphrs = 4;
                    break;


                case FullTime:
                    Emphrs = 8;
                    break;

                default:

                    Emphrs = 0;
                    break;





            }

            int salary = (Emphrs * empRatePerHr);

            totalsalary = (salary + totalsalary);

            Console.WriteLine("Total Salary" + totalsalary);

        }


    }




}



