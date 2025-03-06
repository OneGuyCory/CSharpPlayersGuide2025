Console.Title = "Defense of Consolas";

Console.Write("What is the target row: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the target column: ");
int column = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Deploy to:");
Console.WriteLine($"({row}, {column - 1})");
Console.WriteLine($"({row - 1}, {column})");
Console.WriteLine($"({row}, {column + 1})");
Console.WriteLine($"({row + 1}, {column})");
Console.Beep();