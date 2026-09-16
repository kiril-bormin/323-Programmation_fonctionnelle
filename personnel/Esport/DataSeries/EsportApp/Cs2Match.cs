using System;

namespace DataSeries
{
    public class Cs2Match
    {
        public DateTime Timestamp { get; }
        public string Player { get; }
        public string Map { get; }
        public string StartSide { get; }
        public int Kills { get; }
        public int Deaths { get; }
        public int Assists { get; }
        public int Mvps { get; }
        public bool Won { get; }

        public Cs2Match(DateTime timestamp, string player, string map, string startSide, int kills,
                        int deaths, int assists, int mvps, bool won)
        {
            Timestamp = timestamp;
            Player = player;
            Map = map;
            StartSide = startSide;
            Kills = kills;
            Deaths = deaths;
            Assists = assists;
            Mvps = mvps;
            Won = won;
        }
    }
}