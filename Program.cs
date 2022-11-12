// Task 1 Practice 1
// Take two numbers as input and output which number is greater and which is less.
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


// Task 2 Practice 1
// Take three numbers as input and output the maximum of these numbers.
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


// Task 3 Practice 1
// Take a number as input and output whether the number is even.
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


// Task 4 Practice 1
// Take a number (N) as input and output all even numbers from 1 to N.
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


// Task 1 Practice 2
// Take a three-digit number as input and output the second digit of that number.
internal class Program5
{
    private static void Main(string[] args)
    {
        Console.Write("Number: ");
        int number = int.Parse(Console.ReadLine());
        int result = (number / (int)Math.Pow(10, 1)) % 10;
        Console.Write("The 2nd digit is " + result);

    }
}


// Task 2 Practice 2
// Display the third digit of a given number, or reports that there is no third digit.
internal class Program6
{
    private static void Main(string[] args)
    {
        Console.Write("Number: ");
        int number = int.Parse(Console.ReadLine());
        int count = (int)Math.Floor(Math.Log10(number) + 1);

        if (count < 3) {
            Console.Write("There is no 3rd digit");
        } else {

            // reverse resultant number
            int rem, reverse = 0;  
            while(number != 0)      
            {      
                rem = number % 10;        
                reverse = reverse * 10 + rem;      
                number /= 10;      
            }  

            // find 3rd digit in the number
            int result = (reverse / (int)Math.Pow(10, 2)) % 10;
            Console.Write("The 3rd digit is " + result);

        }
    }
}


// Task 3 Practice 2
// Take as input a number representing the day of the week and check if that day is a holiday.
internal class Program7
{
    private static void Main(string[] args)
    {
        Console.Write("Number: ");
        int number = int.Parse(Console.ReadLine());
        switch (number)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
        }
    }
}


// Task 1 Practice 3
// Take a five-digit number as input and check if it is a palindrome.
internal class Program8 {  
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
// Take the coordinates of two points as input and find the distance between them in 3D space. 
internal class Program9
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
// Take a number (N) as input and produce a table of cubes of numbers from 1 to N. 
internal class Program10 {  
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


// Task 1 Practice 4
// Take two numbers (A and B) as input and raises the number A to the natural power of B. 
// Make it in a function, check for negativity.
internal class Program11 {  
    private static void Main(string[] args)  
    {       

        Console.Write("Enter a base: "); 
        int i = int.Parse(Console.ReadLine()); 

        Console.Write("Enter an exp: "); 
        int n = int.Parse(Console.ReadLine()); 

        decimal y = 1;
        if (n > 0)
        {
            for (int x = 1; x <= n; x++)
                y *= i;               
        }
        if (n < 0)
        {
            for (int x = -1; x >= n; x--)
                y /= i;
        }
        Console.WriteLine("Result: " + y);
    }
}


// Task 2 Practice 4  
// Take a number as input and return the sum of the digits in the number.                 
internal class Program12 { 

    private static void Main(string[] args) 
    {  
        int n, sum = 0, m;         
        Console.Write("Enter a number: ");      
        n = int.Parse(Console.ReadLine());     
        while(n > 0)      
        {      
            m = n % 10;      
            sum = sum + m;      
            n = n / 10;      
        } 

        Console.Write("Sum of digits: " + sum);       
    }  
}  


// Task 3 Practice 4
// Take an array of 8 elements and print them to the screen. 
// The elements are set randomly. 
// The final array must contain the sum of the digits of the number. 
// It is necessary to count the sums of the digits of each number and write them to a new array.
    class Program13
    {
        static void Main(string[] args)
        {
            int i;
            int[] arr = new int[8]; // 8 size array

            // accepting value from input
            for (i = 0; i < 8; i++)
            {
                Console.Write("Enter a number: ");
                // store value in an array
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("\n");

            // print the value on console
            for (i = 0; i < 8; i++)
            {
                {  
                    int sum = 0, m;   

                    while(arr[i] > 0)      
                        {      
                            m = arr[i] % 10;      
                            sum = sum + m;      
                            arr[i] = arr[i] / 10;      
                        } 

                    Console.Write("Sum of digits: " + sum);
                    Console.Write("\n");        

                }
            }
        }        
    }


// Task 1 Practice 5
// Specify an array filled with random positive three-digit numbers. 
// Show the number of even numbers in an array.  
   class Program14
    {       
        static void Main(string[] args)
        {                
             int i;
             int[] arr = new int[4]; // 4 size array

             // accepting value from input
             for (i = 0; i < 4; i++)
             {
                 Console.Write("Enter a number: ");
                 // store value in an array
                 arr[i] = Convert.ToInt32(Console.ReadLine());
             }

            Console.WriteLine(test(arr)); 
        }           
        static int test(int[] nums)
        {
            int evens = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0) evens++;
            }
            return evens;
        }    
   }


// Task 2 Practice 5
// Specify a one-dimensional array filled with random numbers. 
// Find the sum of elements in odd positions.  
public class Program15 {

    public static void Main()
    {
        int i;
        int[] arr = new int[4]; // 4 size array

        // accepting value from input
        for (i = 0; i < 4; i++)
        {
            Console.Write("Enter a number: ");
            // store value in an array
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }       

        int even = 0, odd = 0;

        // loop to find even, odd sum
        for (int j = 0; j < arr.Length; j++)
        {
            if (j % 2 == 0)
                even += arr[j];
            else
                odd += arr[j];
        }

        Console.WriteLine("Even index positions" + " sum: " + even);                            
        Console.WriteLine("Odd index positions " + "sum: " + odd);
    }
}


// Task 3 Practice 5
// Specify an array of real numbers. 
// Find the difference between the max and min elements of the array.  
public class Program16 {

    public static void Main()
    {
        int i;
        int[] arr = new int[4]; // 4 size array

        // accepting value from input
        for (i = 0; i < 4; i++)
        {
            Console.Write("Enter a number: ");
            // store value in an array
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }  

        Console.WriteLine("----------------");
        Console.WriteLine("Minimum number: " + arr.Min());
        Console.WriteLine("Maximum number: " + arr.Max());
        Console.WriteLine("Difference between Max and Min: " + (arr.Max() - arr.Min()));
    }
}


// Task 1 Practice 6
// M numbers are entered from the keyboard. 
// Count how many numbers greater than 0 the user entered.
    class Program17
    {
        static void Main(string[] args)
        {
            int i;
            int[] arr = new int[6]; // 4 size array

            // accepting value from input
            for (i = 0; i < 6; i++)
            {
                Console.Write("Enter a number: ");
                // store value in an array
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }             

            foreach (var item in arr)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine(test(arr));
        }
        public static string test(int[] arr)
        {
            var pos = arr.Where(n => n > 0);
            var neg = arr.Where(n => n < 0);
            return "\nNumber of positive digits: " + pos.Count() + "\nNumber of negative digits: " + neg.Count();
        }
    }


// Task 2 Practice 6
// Find the point of intersection of two lines given by the equations y = k1*x + b1, y = k2*x + b2; 
// the values b1, k1, b2 and k2 are set by the user.
public class Point
{
    public double x, y;

    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    // Method used to display X and Y coordinates of a point
    public static void displayPoint(Point p)
    {
        Console.WriteLine("(" + p.x + ", " + p.y + ")");
    }
}
public class Test
{
    public static Point lineLineIntersection(Point A, Point B, Point C, Point D)
    {
        // Line AB represented as a1x + b1y = c1
        double a1 = B.y - A.y;
        double b1 = A.x - B.x;
        double c1 = a1 * (A.x) + b1 * (A.y);

        // Line CD represented as a2x + b2y = c2
        double a2 = D.y - C.y;
        double b2 = C.x - D.x;
        double c2 = a2 * (C.x) + b2 * (C.y);

        double determinant = a1 * b2 - a2 * b1;

        if (determinant == 0)
        {
            // The lines are parallel
            return new Point(double.MaxValue, double.MaxValue);
        }
        else
        {
            double x = (b2 * c1 - b1 * c2) / determinant;
            double y = (a1 * c2 - a2 * c1) / determinant;
            return new Point(x, y);
        }
    }
    // Driver method
    public static void Main(string[] args)
    {
        Console.Write("k1: ");
        int k1 = int.Parse(Console.ReadLine());
        Console.Write("b1: ");
        int b1 = int.Parse(Console.ReadLine());
        Console.Write("k2: ");
        int k2 = int.Parse(Console.ReadLine());
        Console.Write("b2: ");
        int b2 = int.Parse(Console.ReadLine());        

        Random rnd = new Random();
        int x_A = rnd.Next(1000);
        int x_B = rnd.Next(1000);
        int x_C = rnd.Next(1000);
        int x_D = rnd.Next(1000);

        int y_A = k1 * x_A + b1;
        int y_B = k1 * x_B + b1;
        int y_C = k2 * x_C + b2;
        int y_D = k2 * x_D + b2;

        Point A = new Point(x_A, y_A);
        Point B = new Point(x_B, y_B);
        Point C = new Point(x_C, y_C);
        Point D = new Point(x_D, y_D);

        Point intersection = lineLineIntersection(A, B, C, D);

        if (intersection.x == double.MaxValue && intersection.y == double.MaxValue)
        {
            Console.WriteLine("The given lines AB and CD are parallel.");
        }

        else
        {
           Console.Write("The intersection of the given lines AB " + "and CD: ");
           Point.displayPoint(intersection);
        }
    }
}


// Task 1 Practice 7
// Specify a two-dimensional m × n array filled with random real numbers.
internal class Program18
{
    private static void Main(string[] args)
    {
        Console.Write("m-dimension: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("n-dimension: ");
        int n = int.Parse(Console.ReadLine());

        Random rnd = new Random();
        int[,] arr = new int[m, n];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = rnd.Next(1, 10);
                Console.WriteLine("[{0}, {1}] = {2}", i, j, arr[i, j]);
            }
        }
    }
}


// Task 2 Practice 7
// Takes the position of an element in a two-dimensional array as input and 
// return the value of that element or an indication that there is no such element.
internal class Program19
{
    private static void Main(string[] args)
    {
        int[,] array2D = new int[,] {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};

        Console.Write("m-position: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("n-position: ");
        int n = int.Parse(Console.ReadLine());

        try
            {
                int x = array2D[m, n];
                Console.WriteLine("Value of the element: " + x);
            }

        catch
            {
                Console.WriteLine("There is no element in this position");
            }
    }
}


// Task 3 Practice 7
// Specify a two-dimensional array of integers. 
// Find the mean of the elements in each column.
class Program20
{
    static void Main(string[] args)
    {
        Console.Write("2D-array dimension: ");
        int n = int.Parse(Console.ReadLine());

        int[,] arr = new int[n, n];
        Random rand = new Random();
        int[] summ = new int[n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                arr[i, j] = rand.Next(0, 10); // random numbers      
            }
        }
        Console.WriteLine("2D-array:");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {                
                Console.Write(arr[i, j]);  // print an array
                summ[i] += arr[j, i];      // calculate the sum
            } 
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("Avg of columns:");
        foreach (double elem in summ)
        {            
            Console.WriteLine(elem / n); // return an average
        }
    }
}


// Task 1 Practice 8
// Specify a two-dimensional array. 
// Sort the elements in descending order of each row of a two-dimensional array.
class Program21 { 
    public static int[] GetRow(int[,] matrix, int row)
    {
        var rowLength = matrix.GetLength(1);
        var rowVector = new int[rowLength];
        for (var i = 0; i < rowLength; i++)
            rowVector[i] = matrix[row, i];

        return rowVector;
    }

    static int sortRowWise(int [,]m)
    {
        // One by one sort individual rows
        for (int i = 0;
                 i < m.GetLength(0); i++)
        {
            for (int k = 0;
                     k < m.GetLength(1); k++)
                for (int j = 0;
                         j < m.GetLength(1) - k - 1; j++)
                    if (m[i, j] < m[i, j + 1])
                    {
                        // swap temp and arr[i]
                        int temp = m[i, j];
                        m[i, j] = m[i, j + 1];
                        m[i, j + 1] = temp;
                    }
        }

        // Printing the sorted matrix
        for (int i = 0;
                 i < m.GetLength(0); i++)
        {
            for (int j = 0;
                     j < m.GetLength(1); j++)

        Console.Write(m[i, j] + " ");
        Console.WriteLine();
        }

  return 0;
}
    // Driver code
    public static void Main(String []args)
    {
        int [,]m = {{1, 4, 7, 2},
                    {5, 9, 2, 3},
                    {8, 4, 2, 4}};                
        sortRowWise(m);
    }
}


// Task 2 Practice 8
// Specify a rectangular two-dimensional array. 
// Find the string with the smallest sum of elements.
class Program22 {

    // Get the size m and n
    static int m = 4;
    static int n = 4;

    // Function to calculate sum of each row
    static void row_sum(int[, ] arr)
    {

        int i, j, sum = 0;
        var numbers = new List<int>();
        Console.Write("\nFinding Sum of each row:\n\n");

        // finding the row sum
        for (i = 0; i < m; ++i) {
            for (j = 0; j < n; ++j) {

                // Add the element
                sum = sum + arr[i, j];
            }

            // Print the row sum
            Console.WriteLine("Sum of the row " + i + " = " + sum);        
            numbers.Add(sum);  
            // Reset the sum
            sum = 0;
        }

        var index = numbers.Select((item, index) => (item, index)).Min().index;
        Console.WriteLine("---------------------");
        Console.WriteLine("Row with min sum: " + index);
        Console.WriteLine("---------------------");
    }
    // Driver code
    public static void Main()
    {
        // Get the matrix elements
        int [,] arr = {
            {1, 4, 7, 2},
            {5, 9, 2, 3},
            {8, 4, 2, 4},
            {5, 2, 6, 7}
        };  

        // Get each row sum
        row_sum(arr);
    }
}


// Task 3 Practice 8
// Define two matrices. 
// Find the product of two matrices.
class Program23 {
    static void Main(string[] args) {
        int m = 2, n = 2, p = 2, q = 2, i, j;
        int[,] a = {{2, 4}, {3, 2}};
        int[,] b = {{3, 4}, {3, 3}};
        Console.WriteLine("Matrix a:");
        for (i = 0; i < m; i++) {
        for (j = 0; j < n; j++) {
            Console.Write(a[i, j] + " ");
        }
        Console.WriteLine();
        }
        Console.WriteLine("Matrix b:");
        for (i = 0; i < p; i++) {
        for (j = 0; j < q; j++) {
            Console.Write(b[i, j] + " ");
        }
        Console.WriteLine();
        }
        if(n != p) {
        Console.WriteLine("Matrix multiplication is not possible");
        } else {
        int[,] c = new int[m, q];
        for (i = 0; i < m; i++) {
            for (j = 0; j < q; j++) {
                c[i, j] = 0;
                for (int k = 0; k < n; k++) {
                    c[i, j] += a[i, k] * b[k, j];
                }
            }
        }
        Console.WriteLine("The product of the two matrices is: ");
        for (i = 0; i < m; i++) {
            for (j = 0; j < n; j++) {
                Console.Write(c[i, j] + "\t");
            }
            Console.WriteLine();
            }
        }
    }
}


// Task 4 Practice 8
// Form a three-dimensional array of non-repeating two-digit numbers. 
// Print an array line by line, adding the indexes of each element.
// 2 x 2 x 2 array.
public static class Program24_1
{
    public static void KeyValue<T>(this IEnumerable<T> enumerable, Action<T, int> handler)
    {
        int idx = 0;
        foreach (T item in enumerable)
            handler(item, idx++);
    }
}
public class Program24_2 
{  
    public static void Main(string[] args)  
    {  

        // declaration of 3D array  
        int[,,] arr = new int[2, 2, 2];

        // 0-layer initialization
        arr[0, 0, 0] = 66; int layer_0_00 = arr[0, 0, 0];
        arr[0, 0, 1] = 27; int layer_0_01 = arr[0, 0, 1];
        arr[0, 1, 0] = 25; int layer_0_10 = arr[0, 1, 0];
        arr[0, 1, 1] = 90; int layer_0_11 = arr[0, 1, 1];

        // 1-layer initialization
        arr[1, 0, 0] = 34; int layer_1_00 = arr[1, 0, 0]; 
        arr[1, 0, 1] = 26; int layer_1_01 = arr[1, 0, 1];
        arr[1, 1, 0] = 41; int layer_1_10 = arr[1, 1, 0];
        arr[1, 1, 1] = 55; int layer_1_11 = arr[1, 1, 1];

        {
            int[] layer_0_row_0 = {layer_0_00, layer_0_01};
            int[] layer_0_row_1 = {layer_0_10, layer_0_11};
            int[] layer_1_row_0 = {layer_1_00, layer_1_01};
            int[] layer_1_row_1 = {layer_1_10, layer_1_11};

            Console.WriteLine("-----------------");
            layer_0_row_0.KeyValue((item, idx) => Console.WriteLine("layer0 [0,{0}]: {1}", idx, item));
            layer_0_row_1.KeyValue((item, idx) => Console.WriteLine("layer0 [1,{0}]: {1}", idx, item));
            Console.WriteLine("-----------------");
            layer_1_row_0.KeyValue((item, idx) => Console.WriteLine("layer1 [0,{0}]: {1}", idx, item));
            layer_1_row_1.KeyValue((item, idx) => Console.WriteLine("layer1 [1,{0}]: {1}", idx, item));
            Console.WriteLine("-----------------");
        }
    }  
}  


// Task 5 Practice 8
// Fill 4 x 4 spiral matrix.
public class Program25
{
    public static int[,] GetMatrix(int size)
    {
        var m = new int[size, size];
        (int x, int y) dir = (1, 0), pos = (0, 0);
        (int x, int y) rotate((int x, int y) d) => d.x == 0 ? (-d.y, 0) : (0, d.x);
        (int x, int y) step((int x, int y) p, (int x, int y) d) => (x: p.x + d.x, y: p.y + d.y);
        for (int count = 1; count <= size * size; count++)
        {
            m[pos.y, pos.x] = count;
            var p2 = step(pos, dir);
            try
            {
                if (m[p2.y, p2.x] != 0) throw new IndexOutOfRangeException();
                pos = p2;
            }
            catch (IndexOutOfRangeException)
            {
                dir = rotate(dir);
                pos = step(pos, dir);
            }
        }
        return m;      
    }
    // Driver code
    public static void Main()
    {
        var result = GetMatrix(4);
        int i, j;

        Console.WriteLine("The spiral matrix is: ");     
        for (i = 0; i < 4; i++) {
            for (j = 0; j < 4; j++) {
                Console.Write(result[i, j] + "\t");
            }    
            Console.WriteLine();
        }
    }
}


// Task 1 Practice 9
// Set the value to N. 
// Prints all natural numbers between N and 1. 
// Execute using recursion.
class Program26
{
    static int printNatural(int ctr, int stval)
    {
	    if (ctr < 1)
	    {
	        return stval;
	    }

	Console.Write(" {0} ", ctr);
		ctr--;
	return printNatural(ctr, stval);
    }

    static void Main()
    {
	Console.Write("\n\n Recursion: Print the natural numbers from n to 1 \n");
	Console.Write("------------------------------------------------------\n");
	Console.Write(" How many numbers to print: ");
	int ctr = Convert.ToInt32(Console.ReadLine());
	// Call recursive method with two parameters.	
	printNatural(ctr, 1);
	Console.Write("\n\n");
    }
}


// Task 2 Practice 9
// Give values M and N. 
// Find the sum of positive integers between M and N.
class Program27
{
    private static void Main(string[] args)
    {
        int start, end;

        Console.Write("Enter 1st integer >> ");
        start = int.Parse(Console.ReadLine());
        Console.Write("Enter 2nd integer >> ");
        end = int.Parse(Console.ReadLine());

        int sum = 0;
        for (int x = start; x <= end; x++)
        {
            sum += x;          
        }
    
        Console.WriteLine("Sum of the integers between two numbers: {0} ", sum);
    }
}


// Task 3 Practice 9
// Calculate the Ackermann function using recursion. 
// Two non-negative numbers m and n are given.
class Program28
{
    static int ack(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if((m > 0) && (n == 0))
        {
            return ack(m - 1, 1);
        }
        else if((m > 0) && (n > 0))
        {
            return ack(m - 1, ack(m, n - 1));
        }else
        return n + 1;
    }

    // Driver code
    public static void Main()
    {
        Console.Write("Enter 1st integer >> ");
        int n1 = int.Parse(Console.ReadLine());
        Console.Write("Enter 2nd integer >> ");
        int n2 = int.Parse(Console.ReadLine());         
        
        Console.WriteLine("Result of Ackermann function: " + ack(n1, n2));
    }
}