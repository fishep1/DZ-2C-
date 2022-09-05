// Напишите программу, которая выводит третью цифру слева заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());

    if (a < 100)
{
    Console.WriteLine("В данном числе нет третьей цифры");
}
else if (a > 100)
    {
        while (a >= 1000) 
            a /= 10;
            int d = a % 10;   
         Console.WriteLine(d);
    }
