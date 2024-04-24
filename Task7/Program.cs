// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

Console.WriteLine("Введите целое положительное число из отрезка от 10 до 99: ");
int num = Convert.ToInt32(Console.ReadLine());

int count1 = num / 10;
int count2 = num % 10;

if (num >= 10 && num <= 99)
{
    if (count1 > count2)
    {
        Console.WriteLine("Наибольшая цифра введённого числа = " + count1);
    }
    else
    {
        Console.WriteLine("Наибольшая цифра введённого числа = " + count2);
    }
}
else
{
    Console.WriteLine("Ошибка ввода!");
}