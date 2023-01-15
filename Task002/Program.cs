//Напишите программу, которая на вход принимает 
//два числа и проверяет,
//является ли второе число квадратом первого
//a=5; b=25-> да
//a=2; b=18-> нет
//a=9; b=-3->нет
//a=-3;b=9->да
Console.WriteLine("Введите первое число");
String number = Console.ReadLine();
int b = Convert.ToInt32(number);
Console.WriteLine("Введите второе  число");
String number1 = Console.ReadLine();
int c = Convert.ToInt32(number1);
if(b*b == c)
{
System.Console.WriteLine($"Число {c} является квадратом {b}");
}
else System.Console.WriteLine($"Число {c} не  является квадратом {b}");
