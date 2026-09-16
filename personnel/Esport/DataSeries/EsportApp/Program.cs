using DataSeries;
using EsportApp;
using System.Runtime.Intrinsics.Arm;
using System.Linq;

public class Program()
{
    static void Main(string[] args)
    {
        // Imports
        DataSeries<DataPoint<ValorantMatch>> valorantMatches;
        DataSeries<DataPoint<LolMatch>> lolMatches;
        DataSeries<DataPoint<Cs2Match>> cs2Matches;

        var valorant = DataSeries<ValorantMatch>.FromCsv(@"data\valorant.csv", ParseValorant);
        var lol = DataSeries<LolMatch>.FromCsv("C:\\Users\\px20umf\\Documents\\github\\323-Programmation_fonctionnelle\\personnel\\Esport\\DataSeries\\DataSeries\\data\\lol.csv", ParseLol);
        var cs2 = DataSeries<Cs2Match>.FromCsv(@"data\cs2.csv", ParseCs2);

        var raphGenerated = MatchGenerator.GenerateCs2("Raphaël", 20);
        var noeGenerated = MatchGenerator.GenerateCs2("Noé", 20);
        var kiaraGenerated = MatchGenerator.GenerateCs2("Kiara", 20);

        Console.WriteLine($"Raphaël : {raphGenerated.Values.Count()}");

        // Filtres/Valider

        Func<Cs2Match, bool> isValid = m =>
            m.Kills + m.Assists <= 50 &&
            m.Deaths >= 1;

        var raphaelValid = DataSeries<Cs2Match>.From(
            raphGenerated.Values.Where(isValid)
        );
        var baaad = valorant.Outliers(m => m.Kills < 0);
        Console.WriteLine(valorant.Values.Count()); // 25 — inchangé
        Console.WriteLine(baaad.Values.Count());     // sous-ensemble

        // Interface CLI 
        if (args.Contains("--help"))
        {
            Console.WriteLine("this is help");
        }

        if (args.Contains("--generate"))
        {
            var target = args[Array.IndexOf(args, "--generate") + 1];

            var players = target == "all"
                ? new[] { "Raphaël", "Kiara", "Dylan", "Noé" }
                : new[] { target };

            foreach (var player in players)
            {
                var series = MatchGenerator.GenerateCs2(player, 20);
                ExportCs2(DataSeries<Cs2Match>.From(series.Values.Where(isValid)), $"{player.ToLower()}_generated.csv");
                Console.WriteLine($"{player} données générées et exportées");
            }
            return;     
        }

        Console.WriteLine($"Avant : {raphGenerated.Values.Count()}, après : {raphaelValid.Values.Count()}");

        Console.WriteLine($"Valorant : {valorant.Values.Count()}");
        Console.WriteLine($"League of Legends : {lol.Values.Count()}");
        Console.WriteLine($"CS2 : {cs2.Values.Count()}");

        ExportCs2(raphaelValid, "raphael_generated.csv");
        ExportCs2(noeGenerated, "noé_generated.csv");
        ExportCs2(kiaraGenerated, "kiara_generated.csv");

        Console.WriteLine(Path.GetFullPath("raphael_generated.csv"));



    }
    // Parsers
    static ValorantMatch ParseValorant(string[] cols) => new ValorantMatch(
        DateTime.Parse(cols[0]), // Timestamp
        cols[1],                 // player
        cols[2],                 // agent
        int.Parse(cols[3]),      // kills
        int.Parse(cols[4]),      // deaths
        int.Parse(cols[5]),      // assists
        int.Parse(cols[6]),      // headshots
        int.Parse(cols[7]),      // roundsWon
        bool.Parse(cols[8])      // won
    );

    static Cs2Match ParseCs2(string[] cols) => new Cs2Match(
        DateTime.Parse(cols[0]), // Timestamp
        cols[1],                 // player
        cols[2],                 // map
        cols[3],                 // startSide
        int.Parse(cols[4]),      // kills
        int.Parse(cols[5]),      // deaths
        int.Parse(cols[6]),      // assists
        int.Parse(cols[7]),      // mvps
        bool.Parse(cols[8])      // won
    );

    static LolMatch ParseLol(string[] cols) => new LolMatch(
        DateTime.Parse(cols[0]), // Timestamp
        cols[1],                 // player
        cols[2],                 // champion
        int.Parse(cols[4]),      // kills
        int.Parse(cols[5]),      // deaths
        int.Parse(cols[6]),      // assists
        int.Parse(cols[7]),      // cs
        int.Parse(cols[8]),      // visionScore
        bool.Parse(cols[9])      // won
    );

    // Exports
    static void ExportCs2(DataSeries<Cs2Match> matches, string path)
    {
        var header = "date,player,map,start_side,kills,deaths,assists,mvps,won";
        var lines = matches.Values.Select(m =>
            $"{DateTime.Today:yyyy-MM-dd},{m.Player},{m.Map},{m.StartSide}," +
            $"{m.Kills},{m.Deaths},{m.Assists},{m.Mvps},{m.Won.ToString().ToLower()}"
        );
        File.WriteAllLines(path, lines.Prepend(header));
    }
}
