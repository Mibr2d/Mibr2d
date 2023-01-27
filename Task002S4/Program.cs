// Задача 1: Напишите программу, которая принимает 
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5 

int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int number = Prompt("Введите число");//ввести число
int CountDigits(int number)//функция подсчета цифр в числе
{
    int count = 0;//инициализируем переменную каунт с индекса ноль
    while (number > 0)//условие цикла 
    {
        number = number / 10;// уменьшаем в 10 раз ,подсчитываем разряды
        count++;//увеличиваем счетчик
    }
    return count;//возвращаем результат

}

System.Console.WriteLine($"Количество цифр в числе {number} равно {CountDigits(number)}");//выводим результат
