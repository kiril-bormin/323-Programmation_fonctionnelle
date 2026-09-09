using DataSeries;
using EsportApp;
using System.Runtime.Intrinsics.Arm;
using System.Linq;

public class Program()
{
    static void Main()
    {

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

        Func<Cs2Match, bool> isValid = m =>
            m.Kills + m.Assists <= 50 &&
            m.Deaths >= 1;

        var raphaelValid = DataSeries<Cs2Match>.From(
            raphGenerated.DataPoints.Where(dp => isValid(dp.Value))
        );

        Console.WriteLine($"Avant : {raphGenerated.Values.Count()}, après : {raphaelValid.Values.Count()}");

        Console.WriteLine($"Valorant : {valorant.Values.Count()}");
        Console.WriteLine($"League of Legends : {lol.Values.Count()}");
        Console.WriteLine($"CS2 : {cs2.Values.Count()}");

        ExportCs2(raphaelValid, "raphael_generated.csv");
        ExportCs2(noeGenerated, "noé_generated.csv");
        ExportCs2(kiaraGenerated, "kiara_generated.csv");

        Console.WriteLine(Path.GetFullPath("raphael_generated.csv"));
    }
    static ValorantMatch ParseValorant(string[] cols) => new ValorantMatch(
        cols[1],              // player
        cols[2],              // agent
        int.Parse(cols[3]),   // kills
        int.Parse(cols[4]),   // deaths
        int.Parse(cols[5]),   // assists
        int.Parse(cols[6]),   // headshots
        int.Parse(cols[7]),   // roundsWon
        bool.Parse(cols[8])   // won
    );

    static Cs2Match ParseCs2(string[] cols) => new Cs2Match(
        cols[1],              // player
        cols[2],              // map
        cols[3],              // startSide (côté joué en 1re mi-temps — CT ou T)
        int.Parse(cols[4]),   // kills
        int.Parse(cols[5]),   // deaths
        int.Parse(cols[6]),   // assists
        int.Parse(cols[7]),   // mvps
        bool.Parse(cols[8])   // won
    );

    static LolMatch ParseLol(string[] cols) => new LolMatch(
        cols[1],              // player
        cols[2],              // champion
        int.Parse(cols[4]),   // kills
        int.Parse(cols[5]),   // deaths
        int.Parse(cols[6]),   // assists
        int.Parse(cols[7]),   // cs
        int.Parse(cols[8]),   // visionScore
        bool.Parse(cols[9])   // won
    );

    static void ExportCs2(DataSeries<Cs2Match> matches, string path)
    {
        var header = "date,player,map,start_side,kills,deaths,assists,mvps,won";
        var lines = matches.DataPoints.Select(dp =>
            $"{dp.Timestamp:yyyy-MM-dd},{dp.Value.Player},{dp.Value.Map},{dp.Value.StartSide}," +
            $"{dp.Value.Kills},{dp.Value.Deaths},{dp.Value.Assists},{dp.Value.Mvps},{dp.Value.Won.ToString().ToLower()}"
        );
        File.WriteAllLines(path, lines.Prepend(header));
    }
}
