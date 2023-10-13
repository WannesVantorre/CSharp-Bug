internal class Program
{
    static string[,]? dayHours;
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        dayHours = new string [6, 2];
        Fill();
        Console.WriteLine($"Op {dayHours[1, 0]} is de winkel open van {dayHours[1, 1]} tot {dayHours[1, 2]}.");
        //a
    }

    private static void Fill()
    {
        dayHours[0, 0] = "Monday";
        dayHours[1, 0] = "Dinsdag";
        dayHours[2, 0] = "Woensdag";
        dayHours[3, 0] = "Donderdag";
        dayHours[4, 0] = "Vrijdag";
        dayHours[5, 0] = "Zaterdag";
        dayHours[6, 0] = "Zondag";

        dayHours[0, 1] = "/";
        dayHours[1, 1] = "9:00u";
        dayHours[2, 1] = "9:00u";
        dayHours[3, 1] = "9:00u";
        dayHours[4, 1] = "9:00u";
        dayHours[5, 1] = "8:30u";
        dayHours[6, 1] = "/";

        dayHours[0, 2] = "/";
        dayHours[1, 2] = "18:00u";
        dayHours[2, 2] = "18:00u";
        dayHours[3, 2] = "18:00u";
        dayHours[4, 2] = "18:00u";
        dayHours[5, 2] = "19:30u";
        dayHours[6, 2] = "/";
    }
}