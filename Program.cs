//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
// Console.WriteLine("Введите первое число");
// int number1=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int number2=Convert.ToInt32(Console.ReadLine());
// if (number1 < number2)
// {
// Console.Write("Максимальное число ");
// Console.Write(number2);
// Console.Write(" Минимальное число ");
// Console.Write(number1);
// }
// else
// {
//     Console.Write("Максимальное число ");
// Console.Write(number1);
// Console.Write(" Минимальное число ");
// Console.Write(number2);
// }


// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Введите первое число");
int number1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int number3=Convert.ToInt32(Console.ReadLine());
int max=number1;
if (max <= number2)
max=number2;
if (max <= number3)
max=number3;
Console.Write("Максимальное число ");
Console.Write(max);
