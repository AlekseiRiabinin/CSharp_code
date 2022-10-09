// // Task 1 Practice 1
// internal class Program1
// {
//     private static void Main(string[] args)
//     {
//         Console.Write("First Number: ");
//         int number1 = int.Parse(Console.ReadLine());

//         Console.Write("Second Number: ");
//         int number2 = int.Parse(Console.ReadLine());

//         var max = number1 > number2 ? number1 : number2;
//         var min = number1 < number2 ? number1 : number2;

//         Console.WriteLine("Greatest Number: " + max);
//         Console.WriteLine("Smallest Number: " + min);
//     }
// }


// // Task 2 Practice 1
// namespace Task2 {
//     class Program2 {
//        static void Main(string[] args) {
//             int num1, num2, num3;

//             Console.Write("First Number: ");
//             num1 = int.Parse(Console.ReadLine());

//             Console.Write("Second Number: ");
//             num2 = int.Parse(Console.ReadLine());

//             Console.Write("Third Number: ");
//             num3 = int.Parse(Console.ReadLine());

//             if (num1 > num2) {
//                 if (num1 > num3) {
//                     Console.Write("Number one is the largest!\n");
//                 } else {
//                     Console.Write("Number three is the largest!\n");
//             }
//         }
//         else if (num2 > num3)
//             Console.Write("Number two is the largest!\n");
//         else
//             Console.Write("Number three is the largest!\n");
//         }
//     }
// }


// // Task 3 Practice 1
// internal class Program3
// {
//     private static void Main(string[] args)
//     {
//         Console.Write("Number: ");
//         int number = int.Parse(Console.ReadLine());
//         if (number % 2 == 0)
//         {
//             Console.WriteLine("Number is even");
//         }
//         else
//         {
//             Console.WriteLine("Number is odd");
//         }
//     }
// }


// // Task 4 Practice 1
// namespace Task4
// {
//     class Program4
//     {
//         static void Main(string[] args)
//         {

//             Console.Write("Last Number: ");
//             int N = int.Parse(Console.ReadLine());            
//             int i = 0;

//             Console.WriteLine("Even Numbers :");
//             for (i = 1; i <= N; i++)
//             {   
//                 if( i % 2 == 0 )
//                 {
//                     Console.Write(i + " ");
//                 }
//             }

//             Console.WriteLine("\nOdd Numbers :");
//             for (i = 1; i <= N; i++)
//             {
//                 if (i % 2 != 0)
//                 {
//                     Console.Write(i + " ");
//                 }
//             }

//             Console.WriteLine();
//         }
//     }
// }


// // Task 1 Practice 2
// internal class Program5
// {
//     private static void Main(string[] args)
//     {
//         Console.Write("Number: ");
//         int number = int.Parse(Console.ReadLine());
//         int result = (number / (int)Math.Pow(10, 1)) % 10;
//         Console.Write("The 2nd digit is " + result);

//     }
// }


// // Task 2 Practice 2
// internal class Program6
// {
//     private static void Main(string[] args)
//     {
//         Console.Write("Number: ");
//         int number = int.Parse(Console.ReadLine());
//         int count = (int)Math.Floor(Math.Log10(number) + 1);

//         if (count < 3) {
//             Console.Write("There is no 3rd digit");
//         } else {

//             // reverse resultant number
//             int rem, reverse = 0;  
//             while(number != 0)      
//             {      
//                 rem = number % 10;        
//                 reverse = reverse * 10 + rem;      
//                 number /= 10;      
//             }  

//             // find 3rd digit in the number
//             int result = (reverse / (int)Math.Pow(10, 2)) % 10;
//             Console.Write("The 3rd digit is " + result);

//         }
//     }
// }


// // Task 3 Practice 2
// internal class Program7
// {
//     private static void Main(string[] args)
//     {
//         Console.Write("Number: ");
//         int number = int.Parse(Console.ReadLine());
//         switch (number)
//         {
//             case 1:
//                 Console.WriteLine("Monday");
//                 break;
//             case 2:
//                 Console.WriteLine("Tuesday");
//                 break;
//             case 3:
//                 Console.WriteLine("Wednesday");
//                 break;
//             case 4:
//                 Console.WriteLine("Thursday");
//                 break;
//             case 5:
//                 Console.WriteLine("Friday");
//                 break;
//             case 6:
//                 Console.WriteLine("Saturday");
//                 break;
//             case 7:
//                 Console.WriteLine("Sunday");
//                 break;
//         }
//     }
// }


// Task 1 Practice 3
internal class Program7 {  
    private static void Main(string[] args) {  
        int num, rem, sum = 0, temp;  

        Console.WriteLine("\n >>>> To Find a Number is Palindrome or not <<<< ");  
        Console.Write("\n Enter a number: ");  
        num = Convert.ToInt32(Console.ReadLine());  
        temp = num;  
        while (num > 0) {  
            rem = num % 10; // get remainder by dividing with 10    
            num = num / 10; // get quotient by dividing with 10    
            sum = sum * 10 + rem;  

        }  
        Console.WriteLine("\n The Reversed Number is: {0} \n", sum);  
        if (temp == sum) // check whether the reversed number is equal to entered number    
        {  
            Console.WriteLine("\n Number is Palindrome \n\n");  
        } else {  
            Console.WriteLine("\n Number is not a palindrome \n\n");  
        }  
    }  
}  


// Task 2 Practice 3  
internal class Program8
{
    private static void Main(string[] args)
    {
        // function 
        static void distance(int x1, int y1,
                             int z1, int x2,
                             int y2, int z2)
        {
            double d = Math.Pow(Math.Pow(x2 - x1, 2) +
                                Math.Pow(y2 - y1, 2) +
                                Math.Pow(z2 - z1, 2) *
                                           1.0, 0.5);
            Console.WriteLine("Distance is \n" + d);
            return;
        }

        // driver code
        {

            Console.Write("x1: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("y1: ");
            int y1 = int.Parse(Console.ReadLine());
            Console.Write("z1: ");
            int z1 = int.Parse(Console.ReadLine());

            Console.Write("x2: ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("y2: ");
            int y2 = int.Parse(Console.ReadLine());
            Console.Write("z2: ");
            int z2 = int.Parse(Console.ReadLine());

            // function call
            distance(x1, y1, z1,
                     x2, y2, z2);
        }
    }
}


// Task 3 Practice 3  
internal class Program9 {  
    private static void Main(string[] args)   
    {
        int i, n;

	    Console.Write("\n\n");
        Console.Write("Calculate n terms of cube natural number:\n");
        Console.Write("----------------------------------------------");
        Console.Write("\n\n");     

        Console.Write("Input the number of terms: ");
        n = Convert.ToInt32(Console.ReadLine());     
        Console.Write("\nThe cube natural up to {0} terms are: ", n);
        for(i = 1; i <= n; i++)
        {
            Console.Write("{0}  ", i*i*i);
        }
    } 
}