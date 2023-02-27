// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int Exponentiation(int A, int B)
// {
//     int result = 1;
//     for(int i = 1; i<= B; i++)
//     {
//         result = result *  A;
//     }
//     return result;
// }

// Console.WriteLine("Input A");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input B");
// int B = Convert.ToInt32(Console.ReadLine());

// int exponentiation = Exponentiation (A, B);
// Console.WriteLine("Answer: " + exponentiation);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int SumOfNumbers (int x)
// {
//     int result = 0;
//     while (x>0)
//     { 
//         result += x %10;
//         // result = result + x % 10;
//         // x = x /10;
//         x /= 10;
       
//    }
//     return result;
// }
// Console.WriteLine("Input x");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{SumOfNumbers(x)}");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for(int i = 0;i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1); 
//     }
//     return array;
// }

// void ShowArray (int[] array)
// {
//     for(int i = 0;i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());

//int[] myArray = CreateRandomArray(size, minValue, maxValue);

// ShowArray(CreateRandomArray(size, minValue, maxValue));
