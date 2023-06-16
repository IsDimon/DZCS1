Console.Clear();
Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine());
int I = 1;
if (N<I)
{
   Console.WriteLine("Введено неверное значение N ") ;
   return;

}
while(I<=N)
{
    Console.Write($"  {Math.Pow(I,3)}");
    I++;
}