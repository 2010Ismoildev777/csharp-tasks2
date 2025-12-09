//ClassTask
//Task1
// void PrintFromNumberToOne(int number)
// {
//     for (int i = number; i >= 1; i--)
//     {
//         System.Console.Write(i + " ");
//     }
// }
// PrintFromNumberToOne(5);


//Task2
// int Sum(int a, int b, int c, int d)
// {
//     return a + b + c + d;
// }

// int sum = Sum(1, 2, 3, 4);
// System.Console.WriteLine(sum);


// Task3
// int Reverse(int n)
// {
//     int res = 0;
//     for (int i = n; i != 0; i /= 10)
//     {
//         int digit = i % 10;
//         res = res * 10 + digit;
//     }
//     return res;
// }

// int reverse = Reverse(811);
// System.Console.WriteLine(reverse);


//Task4
//Section1
// void PrintStars(int n)
// {
//     for (int i = 1; i <= n; i++)
//     {
//         System.Console.Write("*");
//     }
//     Console.WriteLine();
// }
// PrintStars(5);

//Section2
// void PrintSquare(int n)
// {
//     for(int i = 1; i <= n; i++)
//     {
//         PrintStars(n);
//     }
// }
// PrintSquare(4);

//Section3
// void PrintRectangle(int width, int height)
// {
//     for(int i = 1; i <= height; i++)
//     {
//         PrintStars(width);
//     }
// }
// PrintRectangle(17, 3);

//Section4
// void PrintTriangle(int size)
// {
//     for(int i = 1; i <= size; i++)
//     {
//         PrintStars(i);
//     }
// }
// PrintTriangle(4);


//Task5
//Section1
// void PrintSpaces(int number)
// {
//     for (int i = 1; i <= number; i++)
//     {
//         System.Console.Write(" ");
//     }
// }

//Section2
// void PrintRightTriangle(int size)
// {
//     for(int i = 1; i <= size; i++)
//     {
//         PrintSpaces(size - i);
//         PrintStars(i);
//     }
// }
// PrintRightTriangle(4);

//Section3
// void Tree(int height)
// {
//     for(int i = 1; i <= height; i++)
//     {
//         PrintSpaces(height - i);
//         PrintStars(2 * i - 1);
//     }
//     for(int i = 1; i <= 2; i++)
//     {
//         PrintSpaces(height - 2);
//         PrintStars(3);
//     }
// }
// Tree(3);


//HomeTask
//Task1
// int EvenCount(int n)
// {
//     int cnt = 0;
//     while (n > 0)
//     {
//         int last = n % 10;
//         if(last % 2 == 0)
//         {
//             cnt++;
//         }
//         n /= 10;
//     }
//     return cnt;
// }
// int OddCount(int n)
// {
//     int cnt = 0;
//     while (n > 0)
//     {
//         int last = n % 10;
//         if(last % 2 != 0)
//         {
//             cnt++;
//         }
//         n /= 10;
//     }
//     return cnt;
// }
// int DigitCount(int n)
// {
//     int cnt = 0;
//     while (n > 0)
//     {
//         cnt++;
//         n /= 10;
//     }
//     return cnt;
// }
// int SumDigit(int n)
// {
//     int sum = 0;
//     while (n > 0)
//     {
//         int last = n % 10;
//         sum += last;
//         n /= 10;
//     }
//     return sum;
// }
// int even = EvenCount(12345);
// int odd = OddCount(12345);
// int digit = DigitCount(12345);
// int sum = SumDigit(12345);
// System.Console.WriteLine($"Even: {even}");
// System.Console.WriteLine($"Odd: {odd}");
// System.Console.WriteLine($"Digit: {digit}");
// System.Console.WriteLine($"Sum: {sum}");


//Task2
// int Add(int a, int b)
// {
//     return a + b;
// }

// int Subtract(int a, int b)
// {
//     return a - b;
// }

// int Multiply(int a, int b)
// {
//     return a * b;
// }

// int Division(int a, int b)
// {
//     return a / b;
// }

// int add = Add(8, 4);
// int subtract = Subtract(8, 4);
// int multiply = Multiply(8, 4);
// int division = Division(8, 4);
// System.Console.WriteLine($"Add: {add}");
// System.Console.WriteLine($"Subtract: {subtract}");
// System.Console.WriteLine($"Multiply: {multiply}");
// System.Console.WriteLine($"Division: {division}");


//Task3
// int MaxDigit(int n)
// {
//     int max = -99999;
//     while (n > 0)
//     {
//         int last = n % 10;
//         if(last > max)
//         {
//             max = last;
//         }
//         n /= 10;
//     }
//     return max;
// }
// int MinDigit(int n)
// {
//     int min = 99999;
//     while (n > 0)
//     {
//         int last = n % 10;
//         if(last < min)
//         {
//             min = last;
//         }
//         n /= 10;
//     }
//     return min;
// }
// int num = Convert.ToInt32(Console.ReadLine());
// int mindigit = MinDigit(num);
// int maxdigit = MaxDigit(num);
// int all = mindigit + maxdigit;
// System.Console.WriteLine($"{mindigit} + {maxdigit} = {all}");


//Task4
// int Pow(int x, int y)
// {
//     int res = 1;
//     for(int i = 1; i <= y; i++)
//     {
//         res *= x;
//     }
//     return res;
// }
// int pow = Pow(2, 3);
// System.Console.WriteLine(pow);


//Task5
// void Swap(ref int a, ref int b)
// {
//     int c = a;
//     a = b;
//     b = c;
// }

// int x = Convert.ToInt32(Console.ReadLine());
// int y = Convert.ToInt32(Console.ReadLine());
// Swap(ref x, ref y);
// System.Console.WriteLine($"x = {x}");
// System.Console.WriteLine($"y = {y}");


//Task6
// void Divisord(int x)
// {
//     for(int i = 1; i <= x; i++)
//     {
//         if(x % i == 0)
//         {
//             System.Console.Write(i + " ");
//         }
//     }
// }

// Divisord(8);


//Task7
void IncrementArrayElements(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write((arr[i] += num) + " ");
    }
}

int[] arr = new int[] { 1, 2, 3 };
IncrementArrayElements(arr, 5);
