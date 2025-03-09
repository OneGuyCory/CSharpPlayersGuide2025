//Ternary opertator example
/*int score = 1;
int score2 = 75;
string textToDisplay = score > 70 ? "You passed!" : "You failed.";

Console.WriteLine(textToDisplay);

if (score2 > 70)
{
    Console.WriteLine("You Passed!");
} else
{
    Console.WriteLine("You Failed.");
}*/

//switch example and switch expression example
Console.WriteLine("Avast, Matey! What be ye desire?");
Console.WriteLine("1 - Rest");
Console.WriteLine("2 - Pillage the port");
Console.WriteLine("3 - Set Sail");
Console.WriteLine("4 - Release the Kraken");
Console.WriteLine("What be the plan, Captain?");
int choice = Convert.ToInt32(Console.ReadLine());
/*switch (choice)
{
    case "1":
        Console.WriteLine("Ye rest and recover your health.");
        break;
    case "2":
        Console.WriteLine("Raiding the port town ye get 50 gold doubloons.");
        break;
    case "3":
        Console.WriteLine("The wind is at your back; the open horizon ahead.");
        break;
    case "4":
        Console.WriteLine("'Tis but a baby Kraken, but still eats toy boats");
        break;
    default:
        Console.WriteLine("Apologies. I do not know that one.");
        break;
}*/

string response;

response = choice switch
{
    1 => "Ye rest and recover your health.",
    2 => "Raiding the port town ye get 50 gold.",
    3 => "The wind is at your back.",
    4 => "'Tis but a baby Kraken, but still eats toy boats",
    _ => "Apologies. I do not know that one."
};
Console.WriteLine(response);