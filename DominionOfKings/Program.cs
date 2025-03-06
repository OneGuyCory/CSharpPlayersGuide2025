Console.Write("How many provinces do you have: ");
int provinces = Convert.ToInt32(Console.ReadLine());

Console.Write("How many duchies do you have: ");
int duchies = Convert.ToInt32(Console.ReadLine());

Console.Write("How many estates do you have: ");
int estates = Convert.ToInt32(Console.ReadLine());

provinces *= 6;
duchies *= 3;
estates *= 1;
int score = provinces + estates + duchies;

Console.WriteLine("Your total score is " + score);