using System;

namespace EmployeeWages
{
    class Program
    {
        public const int Is_PART_TIME = 1;
        public const int Is_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_WORKING_HOURS = 100;

        static void Main(string[] args)
        {
            int totalWorkingHours = 0;
            int totalWorkingDays = 0;
            int empWage = 0;
            int totalEmpWage = 0;

            while (totalWorkingHours < MAX_WORKING_HOURS && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                int emphrs;

                switch (empCheck)
                {
                    case Is_PART_TIME:
                        emphrs = 4;
                        break;
                    case Is_FULL_TIME:
                        emphrs = 8;
                        break;
                    default:
                        emphrs = 0;
                        break;
                }

                totalWorkingHours += emphrs;
                totalWorkingDays++;
                empWage = emphrs * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;
                Console.WriteLine("Day: " + totalWorkingDays + ", Emp Wage: " + empWage);
            }

            Console.WriteLine("Total Emp Wage: " + totalEmpWage);
        }
    }
}
