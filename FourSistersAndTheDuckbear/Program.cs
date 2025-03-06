Console.Write("How many eggs were collected: ");
int eggs = Convert.ToInt32(Console.ReadLine());
int sistersEggs = eggs / 4;
int duckbearsEggs = eggs % 4;

Console.WriteLine($"Each sister will get {sistersEggs} eggs, the duckbear will get {duckbearsEggs} eggs");