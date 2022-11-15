Console.WriteLine("Select N -");
int N = Convert.ToInt32(Console.ReadLine());

int index = 1;

while(index <= N)
{
    if(index % 2 == 0)
    {
        Console.Write(index + " ");
    }
    index++;
}
