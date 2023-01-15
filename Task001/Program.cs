//Напишите программу, которая на вход принимает число и выдает 
//его квадрат (число умноженное на само себя).

//Например:
//4->16
//-3->9
//-7->49

Console.Write("Введите число > ");//Вывод приглашения
String stringValue = Console.ReadLine();//Прочитать строку
int value = Convert.ToInt32(stringValue);//Преобразовываем строку в число

int result = value * value;

Console.WriteLine("Квадрат числа " + value + " равен " + result);
Console.WriteLine($"Квадрат числа {value} равен {result}");