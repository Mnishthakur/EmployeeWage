namespace EmoloyeeWages;

class Program
{
    static void Main(string[] args)
    {
        int Is_FUll_TIME = 1;
        Random random = new Random();

        int empCheck = random.Next(0, 2);
        if (empCheck == Is_FUll_TIME)
        {
            Console.WriteLine("Employee is Present");
        }
        else
        {
            Console.WriteLine("Employee is Absent");
        }
        
    }
}
