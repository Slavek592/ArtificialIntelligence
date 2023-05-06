using System;
using System.Collections.Generic;
using System.Linq;

namespace SP270423
{
    public class KNN
    {
        private List<((double, double), int)> _memory;
        private int _k;
        
        public KNN(int k)
        {
            _memory = new List<((double, double), int)>();
            _k = k;
        }

        public void Train((double, double) data, int type)
        {
            _memory.Add((data, type));
        }

        public int Guess((double, double) data)
        {
            List<((double, double), int)> sorted = _memory.OrderBy(
                x => Math.Pow(x.Item1.Item1 - data.Item1, 2)
                     + Math.Pow(x.Item1.Item2 - data.Item2, 2)
            ).ToList();
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < _k; i++)
            {
                int key = sorted[i].Item2;
                if (dict.ContainsKey(key))
                    dict[key] += 1;
                else
                    dict[key] = 1;
            }

            return dict.OrderByDescending(x => x.Value).First().Key;
        }
        
        public int Test(List<((double, double), int)> data)
        {
            int result = 0;
            foreach (var peace in data)
            {
                if (Guess(peace.Item1) == peace.Item2)
                    result ++;
            }
            return result;
        }
    }
}