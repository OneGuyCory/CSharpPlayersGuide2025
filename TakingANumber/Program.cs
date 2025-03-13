//int result = AskForNumber("what is the airspeed velocity of an unladen swallow");
//Console.WriteLine(result);

int testNum = AskForNumberInRange("Enter a number between 1 and 100", 1, 100);
Console.WriteLine(testNum);




int AskForNumber(string text)
{
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int AskForNumberInRange(string text, int min, int max)
{
    int number;
    do
    {
        Console.WriteLine(text);
        number = Convert.ToInt32(Console.ReadLine());
    } while (number < min || number > max);
    return number;
}

