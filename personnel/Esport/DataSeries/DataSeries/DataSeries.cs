using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DataSeries
{
    public class DataSeries<T>
    {
        private readonly IEnumerable<T> _data;

        private DataSeries(IEnumerable<T> data) => _data = data;
        public static DataSeries<T> From(IEnumerable<DataPoint<T>> source)
            => new DataSeries<T>(source.Select(dp => dp.Value));
        public static DataSeries<T> From(IEnumerable<T> source)
            => new DataSeries<T>(source);

        public IEnumerable<T> Values => _data;

        public static DataSeries<T> FromCsv(string path, Func<string[], T> parser)
        {
            var lines = File.ReadLines(path).Skip(1);
            var items = lines.Select(line => parser(line.Split(',')));
            return new DataSeries<T>(items);
        }
    }
}