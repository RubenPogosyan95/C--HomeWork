Console.WriteLine("Select Number 1 -");
int a1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Select Number 2 -");
int a2 = Convert.ToInt32(Console.ReadLine());

if(a1 < a2)
{
    Console.WriteLine("Max Number = " + a2);
    Console.WriteLine("Min Number = " + a1);
}
else
{
    Console.WriteLine("Max Number = " + a1);
    Console.WriteLine("Min Number = " + a2);
}