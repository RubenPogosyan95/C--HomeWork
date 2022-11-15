Console.WriteLine("Select Number 1 -");
int a1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Select Number 2 -");
int a2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Select Number 3 -");
int a3 = Convert.ToInt32(Console.ReadLine());

int max = a1;

if(a2 > max)
{
    max = a2;
}
if(a3 > max)
{
    max = a3;
}
Console.WriteLine("Max Number = " + max);


