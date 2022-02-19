using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpHrPerMonth;

    public class EmpPerMont
    {

    public const int PartTime = 1;

    public const int FullTime = 2;

    public const int empRatePerHr = 20;

    public const int numofworkingdays = 20;

    public const int MaxHrInMon = 100;


    public static void EmpMonHr()

    {
        int emphrs = 0;



        int totalHr = 0;

        int totalSalary = 0;
        int WorokingDays = 0;


        while (totalHr<MaxHrInMon || WorokingDays < numofworkingdays)
        {

            



            WorokingDays++;
            



            Random random = new Random();
            int num = random.Next(3);

            switch (num)
            {
                case PartTime:
                    emphrs = 4;
                    break;

                case FullTime:
                    emphrs = 8;
                    break;

                default:
                    emphrs = 0;
                    break;

            }

            totalHr = (totalHr + emphrs);

            Console.WriteLine("total hours" + totalHr);





            }

             totalSalary = (totalHr*empRatePerHr);

        Console.WriteLine("totalsalary" + totalSalary);






    }
}

