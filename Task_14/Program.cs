// Задача 14.
// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num % 7;
int num2 = num % 23;
if (num1 == 0 && num2 == 0)
{
    Console.WriteLine($"Число {num} кратно одновременно 7 и 23");
}
else
{
    Console.WriteLine($"Число {num} не кратно одновременно 7 и 23");
}