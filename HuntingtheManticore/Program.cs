int manticoreHealth = 10;
int cityHealth = 15;
int round = 1;
string border = "-----------------------------------------------------------";


Console.Write("Player 1, how far away from the city do you to station the manticore? (0-100) ");
int target = Convert.ToInt32(Console.ReadLine());
Console.Clear();

Console.WriteLine("Player 2, it is your turn.");

do
{
    Console.WriteLine(border);
    Console.WriteLine($"STATUS: Round: {round} City: {cityHealth}/15 Manticore: {manticoreHealth}/10");
    Console.WriteLine($"The cannon is expected to deal {CannonDamage(round)} damage this round.");
    Console.Write("Enter desired cannon range: ");
    int distance = Convert.ToInt32(Console.ReadLine());
    TargetDistance(distance);
    round++;
    cityHealth--;
    if (manticoreHealth == 0)
    {
        Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
    }

} while (cityHealth > 0 && manticoreHealth > 0);

int CannonDamage(int round)
{
    if (round % 5 == 0 && round % 3 == 0)
    {
        return 10;
    } else if (round % 5 == 0 || round % 3 == 0)
    {
        return 3;
    }
    else
    {
        return 1;
    }
}

void TargetDistance(int distance)
{
    if (distance > target)
    {
        Console.Write("That round OVERSHOT the target.\n");
        
    } else if (distance < target)
    {
        Console.Write("That round FELL SHORT of the target\n");
        
    }
    else
    {
        Console.Write("That round was a DIRECT HIT!\n");
        manticoreHealth -= CannonDamage(round);
    }
}