using DataSeries;
using EsportApp;

public class Program()
{
    static void Main()
    {
        Console.WriteLine("hello");

        var valorantMatches = new[]

        {
            new ValorantMatch("Léa", "Jett",  18, 6, 4, 8,  13, true),
            new ValorantMatch("Léa", "Reyna", 22, 8, 2, 11,  9, false),
            new ValorantMatch("Léa", "Neon",  20, 7, 5,  9, 13, true),
        };

        var valorant = DataSeries<ValorantMatch>.From(valorantMatches);
        Console.WriteLine(valorant.Count); // 3


        var lolMatches = new[]
        {
            new LolMatch("Léa", "Jett",  18, 6, 4, 8,  13, true),
            new LolMatch("Léa", "Reyna", 22, 8, 2, 11,  9, false),
            new LolMatch("Léa", "Neon",  20, 7, 5,  9, 13, true),
            new LolMatch("Léa", "Reynad", 22, 8, 2, 11,  9, false),

        };

        var lol = DataSeries<LolMatch>.From(lolMatches);
        Console.WriteLine(lol.Count); // 4

    }
}