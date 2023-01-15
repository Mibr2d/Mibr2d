//Напишите программу, которая на вход принимает число и выдает 
//его квадрат (число умноженное на само себя).

//Например:
//4->16
//-3->9
//-7->49

Console.Write("Введите число > ");
String stringValue = Console.ReadLine();
int value = Convert.ToInt32(stringValue);

int result = value * value;

Console.WriteLine("Квадрат числа " + value + " равен " + result);
System.Console.WriteLine($"Квадрат числа {value} равен {result}");