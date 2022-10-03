// Task 1
internal class Program1
{
    private static void Main(string[] args)
    {
        Console.Write("First Number: ");
        int number1 = int.Parse(Console.ReadLine());

        Console.Write("Second Number: ");
        int number2 = int.Parse(Console.ReadLine());

        var max = number1 > number2 ? number1 : number2;
        var min = number1 < number2 ? number1 : number2;

        Console.WriteLine("Greatest Number: " + max);
        Console.WriteLine("Smallest Number: " + min);
    }
}


// Task 2
namespace Task2 {
    class Program2 {
       static void Main(string[] args) {
            int num1, num2, num3;

            Console.Write("First Number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Second Number: ");
            num2 = int.Parse(Console.ReadLine());

            Console.Write("Third Number: ");
            num3 = int.Parse(Console.ReadLine());

            if (num1 > num2) {
                if (num1 > num3) {
                    Console.Write("Number one is the largest!\n");
                } else {
                    Console.Write("Number three is the largest!\n");
            }
        }
        else if (num2 > num3)
            Console.Write("Number two is the largest!\n");
        else
            Console.Write("Number three is the largest!\n");
        }
    }
}


// Task 3
internal class Program3
{
    private static void Main(string[] args)
    {
        Console.Write("Number: ");
        int number = int.Parse(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine("Number is even");
        }
        else
        {
            Console.WriteLine("Number is odd");
        }
    }
}


// Task 4
namespace Task4
{
    class Program4
    {
        static void Main(string[] args)
        {

            Console.Write("Last Number: ");
            int N = int.Parse(Console.ReadLine());            
            int i = 0;

            Console.WriteLine("Even Numbers :");
            for (i = 1; i <= N; i++)
            {   
                if( i % 2 == 0 )
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine("\nOdd Numbers :");
            for (i = 1; i <= N; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine();
        }
    }
}