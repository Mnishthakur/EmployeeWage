namespace EmoloyeeWages;

class Program
{
    public const int Is_PART_TIME = 1;
    public const int Is_FULL_TIME = 2;
    public const int EMP_RATE_PER_HOUR = 20;
    public const int NUM_OF_WORKING_DAYS = 2;
    static void Main(string[] args)
    {
        

        int emphrs = 0, empWage = 0, totalEmpWage = 0;


        for (int day = 0; day <NUM_OF_WORKING_DAYS; day++)
        {
            Random random = new Random();

            int empCheck = random.Next(0, 3);
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
            empWage = emphrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage :" + empWage);

        }
        Console.WriteLine("Total Emp Wage" + totalEmpWage);
        
    }
}

