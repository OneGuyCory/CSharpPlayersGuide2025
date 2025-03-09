int[] numArr = new int[5];
int[] numArr2 = new int[5];
int count = 0;

Console.WriteLine("Welcome to the Replicator! We need to input 5 numbers");

do
{
    Console.Write("Please enter a number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    numArr[count] = num;
    count++;
} while (count < 5);

for (int i = 0; i < numArr.Length; i++)
{
    numArr2[i] = numArr[i];
}

foreach (int i in numArr)
{
    Console.WriteLine($"Your numbers are: {i}");
}

foreach (int j in numArr2)
{
    Console.WriteLine($"The replicated numbers are: {j}");
}