using DataSeries;
using EsportApp;

public class Program()
{
    static void Main()
    {

        DataSeries<DataPoint<ValorantMatch>> valorantMatches;
        DataSeries<DataPoint<LolMatch>> lolMatches; 
        DataSeries<DataPoint<Cs2Match>> cs2Matches;



        var valorant = DataSeries<ValorantMatch>.FromCsv("C:\\Users\\px20umf\\Documents\\github\\323-Programmation_fonctionnelle\\personnel\\Esport\\DataSeries\\DataSeries\\data\\valorant.csv", ParseValorant);
        var lol = DataSeries<LolMatch>.FromCsv("C:\\Users\\px20umf\\Documents\\github\\323-Programmation_fonctionnelle\\personnel\\Esport\\DataSeries\\DataSeries\\data\\lol.csv", ParseLol);
        var cs2 = DataSeries<Cs2Match>.FromCsv("C:\\Users\\px20umf\\Documents\\github\\323-Programmation_fonctionnelle\\personnel\\Esport\\DataSeries\\DataSeries\\data\\cs2.csv", ParseCs2);

        Console.WriteLine($"Valorant : {valorant.Values.Count()}");
        Console.WriteLine($"League of Legends : {lol.Values.Count()}");
        Console.WriteLine($"CS2 : {cs2.Values.Count()}");

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
}