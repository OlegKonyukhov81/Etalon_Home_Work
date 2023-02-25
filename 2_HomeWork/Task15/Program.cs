// понедельник -> Нет
// суббота -> Да

int Prompt(string message)
{
Console.Write(message);
string value = Console.ReadLine();
int result = Convert.ToInt32(value);
return result;
}

bool ValidateWeek(int number)
{
    if (number > 0 && number <= 7)
    {
        return (true);
    }
    Console.WriteLine("Это не день недели!");
    return (false);
}

bool SearchWeekEnd(int number)
{
    if (number > 5)
    {
        return (true);
    }
    return (false);
}

int weekDay = Prompt("Введите день недели: ");
if (ValidateWeek(weekDay))
{
    if (SearchWeekEnd(weekDay))
    {
        Console.WriteLine("Ура! Сегодня Выходной!");
    }
    Console.WriteLine("Придется еще поработать!");
}