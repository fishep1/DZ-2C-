Console.WriteLine("введите номер дня недели ");

int a = Convert.ToInt32(Console.ReadLine()); // конвертируем строку в число

string dayOfWeek = ("день недели");
if (a == 1)
{
dayOfWeek = ("Понедельник");
}
if (a == 2)
{
dayOfWeek = ("вторник");
}
if (a == 3)
{
dayOfWeek = ("среда");
}
if (a == 4)
{
dayOfWeek = ("четверг");
}
if (a == 5)
{
dayOfWeek = ("Пятница");
}
if (a == 6)
{
dayOfWeek = ("Суббота");
}
if (a == 7)
{
dayOfWeek = ("воскресенье");
}
Console.WriteLine(dayOfWeek);
