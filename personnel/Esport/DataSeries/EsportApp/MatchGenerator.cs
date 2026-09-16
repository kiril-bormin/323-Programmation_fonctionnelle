using DataSeries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsportApp
{
    internal class MatchGenerator
    {
        public static DataSeries<Cs2Match> GenerateCs2(string player, int count, int seed = 42)
        {
            var rng = new Random(seed);
            var maps = new[] { "Mirage", "Dust2", "Nuke", "Adonis" };
            var sides = new[] { "CT", "T" };
            var start = new DateTime(2023, 9, 1);

            return DataSeries<Cs2Match>.From(
                Enumerable.Range(1, count)
                    .Select(i => new Cs2Match(
                        start.AddDays(i), 
                        player,
                        maps[rng.Next(maps.Length)],
                        sides[rng.Next(2)],
                        rng.Next(10, 28),
                        rng.Next(6, 18),
                        rng.Next(0, 8),
                        rng.Next(0, 5),
                        rng.Next(2) == 0  // won
                    ))
            );
        }
    }
}
