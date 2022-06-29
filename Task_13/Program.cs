// Задача 13.
// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("ВВедите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99)
{
    int num1 = num;
    int n = 0;
    while (num1 > 0)
    {
        num1 = num1 / 10;
        n++;
    }
    // Console.WriteLine($"Число {num} состоит из {n} цифр");


    int num2 = num;
    while (n > 3)
    {
        num2 = num2 / 10;
        n--;
    }
    int num3 = num2 % 10;
    Console.Write("Третья цифра числа: ");
    Console.WriteLine(num3);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}


