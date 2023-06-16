int Prompt(string msg)
{

System.Console.WriteLine($"{msg}");
return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("Введите число");
string ss = "Это не день недели";
string check(int number)
{

if (number >= 1 && number < 2) ss = "Это Понедельник";
if (number >= 2 && number < 3) ss = "Это Вторник";
if (number >= 3 && number < 4) ss = "Это Среда";
if (number >= 4 && number < 5) ss = "Это Четверг";
if (number >= 5 && number < 6) ss = "Это Пятница";
if (number >= 6 && number < 7) ss = "Это Суббота - Выходной";
if (number >= 7 && number < 8) ss = "Это Воскресенье - Выходной";
return ss;
}
System.Console.WriteLine(check(number));
