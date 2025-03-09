Console.WriteLine("Hello! Welcome to Tortugas shop! What is your name?");
string name = Console.ReadLine().ToLower();
Console.WriteLine("The following items are available: ");
Console.WriteLine("1 - Rope");
Console.WriteLine("2 - Torches");
Console.WriteLine("3 - Climbing Equipment");
Console.WriteLine("4 - Clean Water");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food Supplies");
Console.Write("Which would you like to see the price of? ");
int itemNumber = Convert.ToInt32(Console.ReadLine());

string response;

if (name == "cory")
{
    response = itemNumber switch
    {
        1 => "Rope costs 5 gold.",
        2 => "Torches cost 8 gold.",
        3 => "Climbing Equipment costs 13 gold.",
        4 => "Clean water costs .5 gold.",
        5 => "Machete costs 10 gold.",
        6 => "A canoe costs 100 gold.",
        7 => "Food supplies cost .5 gold.",
        _ => "Sorry that's not a valid choice."
    };
}
else
{
    response = itemNumber switch
    {
        1 => "Rope costs 10 gold.",
        2 => "Torches cost 15 gold.",
        3 => "Climbing Equipment costs 25 gold.",
        4 => "Clean water costs 1 gold.",
        5 => "Machete costs 20 gold.",
        6 => "A canoe costs 200 gold.",
        7 => "Food supplies cost 1 gold.",
        _ => "Sorry that's not a valid choice."
    };
}
Console.WriteLine(response);