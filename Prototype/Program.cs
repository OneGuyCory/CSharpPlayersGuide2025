int numberToGuess;
int guess;

do
{
    Console.Write("User 1, enter a number between 0 and 100: ");
    numberToGuess = Convert.ToInt32(Console.ReadLine());
}
while (numberToGuess < 0 || numberToGuess > 100);

Console.Clear();

Console.WriteLine("User 2, guess the number.");

do
{
    Console.WriteLine("What is your next guess? ");
    guess = Convert.ToInt32(Console.ReadLine());
    if (guess > numberToGuess)
    {
        Console.WriteLine($"{guess} is too high.");
    } else if (guess < numberToGuess)
    {
        Console.WriteLine($"{guess} is too low.");
    }
    else
    {
        Console.WriteLine("You Guessed the number!");
    }
}
while (guess != numberToGuess);

