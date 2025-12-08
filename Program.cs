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
