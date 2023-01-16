// 4. Напишите программу, которая принимает на вход 
// число и проверяет, кратно ли оно одновременно 7 и 
// 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да


// int InputInt(string message)
// {
//     Console.WriteLine(message);
//     int number = Convert.ToInt32(Console.ReadLine());
//     return number;
// }
// int firstNumber = InputInt("Введите число");
// int number1=7;
// int number2=23;
// if (firstNumber % number1 == 0)
// {
//     Console.WriteLine("Число кратно 7");
// }
// else
// {
//     Console.WriteLine("Не кратно 7");
// }
// if (firstNumber % number2 == 0)
// {
//     Console.WriteLine("Число кратно 23");
// }
// else
// {
//     Console.WriteLine("Число не кратно 23");
// }



int InputInt(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int firstNumber = InputInt("Введите число");
int divider1=7;
int divider2=23;
if (firstNumber % divider1 == 0 && firstNumber%divider2==0)
{
Console.WriteLine("да");
}
else
{
    Console.WriteLine("Нет");
}
