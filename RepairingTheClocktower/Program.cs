Console.Write("Please input a number to determine tick or tock: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("Tick");
} else
{
    Console.WriteLine("Tock");
}