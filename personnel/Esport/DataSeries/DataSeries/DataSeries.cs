using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSeries
{
    internal class DataPoint<T>
    {
        public DateTime Timestamp { get; }
        public T Value { get; }

        public DataPoint(DateTime timestamp, T value)
        {
            Timestamp = timestamp;
            Value = value;
        }
    }
    public class DataSeries<T>
    {
    private readonly IEnumerable<T> _data;

    private DataSeries(IEnumerable<T> data) => _data = data;

    public static DataSeries<T> From(IEnumerable<T> source) => new DataSeries<T>(source);

    public int Count => _data.Count();

    public IEnumerable<T> Values => _data;
    }
}
