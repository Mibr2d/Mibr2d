// 3. Напишите программу, которая будет принимать на 
// вход два числа и выводить, является ли второе число 
// кратным первому. Если число 2 не кратно числу 1, то 
// программа выводит остаток от деление.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

int InputInt(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int number1 = InputInt("Введите  число для проверки");
int number2 = InputInt("Введите которым хотите проверить");
if (number1 % number2 == 0)
{
    Console.WriteLine("Число  кратно "+number2);
}
else
{
    Console.WriteLine("Число не кратно" + number1);
}