// Задача 2: Напишите программу, которая 
// принимает на вход число N и выдаёт 
// произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int Factorial(int n)
{
    int Prod = 1;
    for (int i = 1; i <= n; i++)
    {
        Prod = Prod * i;
    }
    return Prod;

}
int number = Prompt("Введите число от 1 до ... ");

int result = Factorial(number);
System.Console.WriteLine($"Количество цифр в числе {number} равно {result}");