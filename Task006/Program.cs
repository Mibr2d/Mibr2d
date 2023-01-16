// 1. Напишите программу, которая принимает 
// на вход трёхзначное число и на выходе 
// показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8
int InputInt(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = InputInt("Введите трехзначное число");
if (number > 99 && number < 1000)
{
    int result = number % 10;
    Console.WriteLine("Последняя цифра числа равна " + result);
}
else
{
    Console.WriteLine("Число не трехзначное ");
}