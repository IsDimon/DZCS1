Console.Write("Введите трехзначное число ");
int number = Convert.ToInt32(Console.ReadLine());
if(((number / 100) > 0) && ((number / 1000) < 1) )
{
int lastNumber = number % 10;
Console.WriteLine( $"Последней цифра числа {number} является {lastNumber}" );
}
else {
    Console.WriteLine("Это число не трехзначное ");
}
