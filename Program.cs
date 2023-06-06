namespace EmoloyeeWages;

class Program
{
    static void Main(string[] args)
    {
        int Is_FUll_TIME = 1;
        int EMP_RATE_PER_HOUR = 20;

        int emphrs = 0;
        int empWage = 0;

        Random random = new Random();

        int empCheck = random.Next(0, 2);
        if (empCheck == Is_FUll_TIME)
        {
            emphrs = 8;
        }
        else
        {
            emphrs = 0;
        }
        empWage = emphrs * EMP_RATE_PER_HOUR;
        Console.WriteLine("Emp Wage :" + empWage);
    }
}

