//3. Напишите программу вычисления функции:
//x = f(a) Куб числа.

Console.Write("Введите число > ");
String stringValue = Console.ReadLine();
int value = Convert.ToInt32(stringValue);

int result = value * value * value;

Console.WriteLine("Куб числа " + value + " равен " + result);
Console.WriteLine($"Куб числа {value} равен {result}");

