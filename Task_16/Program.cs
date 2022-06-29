// Задача 16
// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет


Console.Write("Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());


Console.Write("Введите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int kv1 = num1 * num1;
int kv2 = num2 * num2;

if (kv1 == num2 || kv2 == num1)
{
    Console.WriteLine("одно число является квадратом другого");
}
else
{
    Console.WriteLine("одно число не является квадратом другого");  
}