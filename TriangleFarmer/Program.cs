Console.Write("What is the base of the triangle: ");
double baseSize = Convert.ToDouble(Console.ReadLine());

Console.Write("What is the height of the triangle: ");
double height  = Convert.ToDouble(Console.ReadLine());
double area = (baseSize * height) / 2;

Console.WriteLine($"The area of your triangle is {area}");