using System.Collections.Generic;
using System.Linq;

namespace BulkDeleteManager
{
    public class Recurrency
    {
        public string Frequence;
        public int Interval;

        public Recurrency(string pattern)
        {
            var patters = pattern.Split(';').Where(p => !string.IsNullOrWhiteSpace(p)).Select(p => new KeyValuePair<string, string>(p.Split('=')[0], p.Split('=')[1]));
            Frequence = patters.FirstOrDefault(p => p.Key == "FREQ").Value;
            int.TryParse(patters.FirstOrDefault(p => p.Key == "INTERVAL").Value, out Interval);
        }

        public override string ToString()
        {
            return ToString(Frequence, Interval);
        }

        public static string ToString(string frequence, int interval)
        {
            var result = string.Empty;
            if (!string.IsNullOrWhiteSpace(frequence) && !frequence.StartsWith("-"))
            {
                result += $"FREQ={frequence}";
                if (interval > 0)
                {
                    result += ";";
                }
            }
            if (interval > 0)
            {
                result += $"INTERVAL={interval}";
            }
            return result;
        }
    }

    //public enum RecurrencyFrequence
    //{
    //    Monthly,
    //    Weekly,
    //    Daily,
    //    Hourly,
    //    None
    //}
}
