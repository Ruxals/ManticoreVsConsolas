
Console.Title = "Manticore Vs Consolas";

int p1HP = 10;
int p2HP = 15;
int MantiRange;
int ConsolasRange;

Console.ForegroundColor = ConsoleColor.Red; 
Console.WriteLine("Player 1, how far should we station the Manticore (0-100) Meters?");
MantiRange = int.Parse(Console.ReadLine());

//Methods

static int HitCases(int ManRange, int ConsRange)
{

    if (ConsRange == ManRange)
    {
        return 1;
    }
    else if (ConsRange < ManRange)
    {
        return 2;
    }
    else
    { // ConsRange > ManRange 
        return 3;
    }
}

static int roundType(int roundNum)
{
    if (roundNum % 3 == 0) { return 3; }
    if (roundNum % 5 == 0) { return 5; }
    return 1; // if not 3 or 5 then 1 damage then.
}

for (int i = 0; i < 50; i++)
{
    if (p1HP == 0) { Console.WriteLine("The Consolas Has Won!"); break; }
    if (p2HP == 0) { Console.WriteLine("The Manticore Has Won!"); break; }
    Console.ForegroundColor = ConsoleColor.Yellow; 
    int round = i + 1;
    Console.WriteLine($"Round: {round} City: {p2HP} Manticore: {p1HP} ");
    int damage = roundType(round);
    Console.WriteLine($"\nThe Canon is expected to deal {damage} damage.");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Player 2, Choose Desired Range");
    ConsolasRange = int.Parse(Console.ReadLine());
    int HitCase = HitCases(ConsolasRange, MantiRange);

    if (HitCase == 1) { Console.ForegroundColor = ConsoleColor.Blue; p1HP -= damage; Console.WriteLine("\nDirect Hit!"); p2HP--; }
    if (HitCase == 2) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("\nToo short off range!"); p2HP--; }
    if (HitCase == 3) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("\nTo far off range!"); p2HP--; }

}



