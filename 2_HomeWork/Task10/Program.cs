// 456 -> 5
// 782 -> 8

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int number = Prompt("Введите трехзначное число: ");
if  (number < 100 || number >= 1000)
{
    Console.WriteLine("Вы ввели не трехзначное число, повторите ввод");
    return;
}
Console.WriteLine($"Введеное число {number}");
int secondRank = number / 10 % 10;
Console.WriteLine($"Вторая цифра {secondRank}");
