// 4. Напишите программу, которая принимает на вход 
// число и проверяет, кратно ли оно одновременно 7 и 
// 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да


int InputInt(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int firstNumber = InputInt("Введите число");
if (firstNumber%7==0)
{
    Console.WriteLine("Число кратно 7");
}
else
{
Console.WriteLine("Не кратно 7");
}
if(firstNumber%23==0)
{
Console.WriteLine("Число кратно 23");
}
else
{
    Console.WriteLine("Число не кратно 23");
}
