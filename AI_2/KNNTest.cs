using System;
using System.Collections.Generic;

namespace SP270423
{
    public class KNNTest
    {
        public static void Main()
        {
            KNN knn = new KNN(10);
            knn.Train((5.1, 3.5), 0);
            knn.Train((4.9, 3.0), 0);
            knn.Train((4.7, 3.2), 0);
            knn.Train((4.6, 3.1), 0);
            knn.Train((5.0, 3.6), 0);
            knn.Train((5.4, 3.9), 0);
            knn.Train((4.6, 3.4), 0);
            knn.Train((5.0, 3.4), 0);
            knn.Train((4.4, 2.9), 0);
            knn.Train((4.9, 3.1), 0);
            knn.Train((5.4, 3.7), 0);
            knn.Train((4.8, 3.4), 0);
            knn.Train((4.8, 3.0), 0);
            knn.Train((4.3, 3.0), 0);
            knn.Train((5.8, 4.0), 0);
            knn.Train((5.7, 4.4), 0);
            knn.Train((5.4, 3.9), 0);
            knn.Train((5.1, 3.5), 0);
            knn.Train((5.7, 3.8), 0);
            knn.Train((5.1, 3.8), 0);
            knn.Train((5.4, 3.4), 0);
            knn.Train((5.1, 3.7), 0);
            knn.Train((4.6, 3.6), 0);
            knn.Train((5.1, 3.3), 0);
            knn.Train((4.8, 3.4), 0);
            knn.Train((5.0, 3.0), 0);
            knn.Train((5.0, 3.4), 0);
            knn.Train((5.2, 3.5), 0);
            knn.Train((5.2, 3.4), 0);
            knn.Train((4.7, 3.2), 0);
            knn.Train((4.8, 3.1), 0);
            knn.Train((5.4, 3.4), 0);
            knn.Train((5.2, 4.1), 0);
            knn.Train((5.5, 4.2), 0);
            knn.Train((4.9, 3.1), 0);
            knn.Train((5.0, 3.2), 0);
            knn.Train((5.5, 3.5), 0);
            knn.Train((4.9, 3.1), 0);
            knn.Train((4.4, 3.0), 0);
            knn.Train((5.1, 3.4), 0);
            knn.Train((5.0, 3.5), 0);
            knn.Train((4.5, 2.3), 0);
            knn.Train((4.4, 3.2), 0);
            knn.Train((5.0, 3.5), 0);
            knn.Train((5.1, 3.8), 0);
            knn.Train((4.8, 3.0), 0);
            knn.Train((5.1, 3.8), 0);
            knn.Train((4.6, 3.2), 0);
            knn.Train((5.3, 3.7), 0);
            knn.Train((5.0, 3.3), 0);
            knn.Train((7.0, 3.2), 1);
            knn.Train((6.4, 3.2), 1);
            knn.Train((6.9, 3.1), 1);
            knn.Train((5.5, 2.3), 1);
            knn.Train((6.5, 2.8), 1);
            knn.Train((5.7, 2.8), 1);
            knn.Train((6.3, 3.3), 1);
            knn.Train((4.9, 2.4), 1);
            knn.Train((6.6, 2.9), 1);
            knn.Train((5.2, 2.7), 1);
            knn.Train((5.0, 2.0), 1);
            knn.Train((5.9, 3.0), 1);
            knn.Train((6.0, 2.2), 1);
            knn.Train((6.1, 2.9), 1);
            knn.Train((5.6, 2.9), 1);
            knn.Train((6.7, 3.1), 1);
            knn.Train((5.6, 3.0), 1);
            knn.Train((5.8, 2.7), 1);
            knn.Train((6.2, 2.2), 1);
            knn.Train((5.6, 2.5), 1);
            knn.Train((5.9, 3.2), 1);
            knn.Train((6.1, 2.8), 1);
            knn.Train((6.3, 2.5), 1);
            knn.Train((6.1, 2.8), 1);
            knn.Train((6.4, 2.9), 1);
            knn.Train((6.6, 3.0), 1);
            knn.Train((6.8, 2.8), 1);
            knn.Train((6.7, 3.0), 1);
            knn.Train((6.0, 2.9), 1);
            knn.Train((5.7, 2.6), 1);
            knn.Train((5.5, 2.4), 1);
            knn.Train((5.5, 2.4), 1);
            knn.Train((5.8, 2.7), 1);
            knn.Train((6.0, 2.7), 1);
            knn.Train((5.4, 3.0), 1);
            knn.Train((6.0, 3.4), 1);
            knn.Train((6.7, 3.1), 1);
            knn.Train((6.3, 2.3), 1);
            knn.Train((5.6, 3.0), 1);
            knn.Train((5.5, 2.5), 1);
            knn.Train((5.5, 2.6), 1);
            knn.Train((6.1, 3.0), 1);
            knn.Train((5.8, 2.6), 1);
            knn.Train((5.0, 2.3), 1);
            knn.Train((5.6, 2.7), 1);
            knn.Train((6.3, 3.3), 2);
            knn.Train((5.8, 2.7), 2);
            knn.Train((7.1, 3.0), 2);
            knn.Train((6.3, 2.9), 2);
            knn.Train((6.5, 3.0), 2);
            knn.Train((7.6, 3.0), 2);
            knn.Train((4.9, 2.5), 2);
            knn.Train((7.3, 2.9), 2);
            knn.Train((6.7, 2.5), 2);
            knn.Train((7.2, 3.6), 2);
            knn.Train((6.5, 3.2), 2);
            knn.Train((6.4, 2.7), 2);
            knn.Train((6.8, 3.0), 2);
            knn.Train((5.7, 2.5), 2);
            knn.Train((5.8, 2.8), 2);
            knn.Train((6.4, 3.2), 2);
            knn.Train((6.5, 3.0), 2);
            knn.Train((7.7, 3.8), 2);
            knn.Train((7.7, 2.6), 2);
            knn.Train((6.0, 2.2), 2);
            knn.Train((6.9, 3.2), 2);
            knn.Train((5.6, 2.8), 2);
            knn.Train((7.7, 2.8), 2);
            knn.Train((6.3, 2.7), 2);
            knn.Train((6.7, 3.3), 2);
            knn.Train((7.2, 3.2), 2);
            knn.Train((6.2, 2.8), 2);
            knn.Train((6.1, 3.0), 2);
            knn.Train((6.4, 2.8), 2);
            knn.Train((7.2, 3.0), 2);
            knn.Train((7.4, 2.8), 2);
            knn.Train((7.9, 3.8), 2);
            knn.Train((6.4, 2.8), 2);
            knn.Train((6.3, 2.8), 2);
            knn.Train((6.1, 2.6), 2);
            knn.Train((7.7, 3.0), 2);
            knn.Train((6.3, 3.4), 2);
            knn.Train((6.4, 3.1), 2);
            knn.Train((6.0, 3.0), 2);
            knn.Train((6.9, 3.1), 2);
            knn.Train((6.7, 3.1), 2);
            knn.Train((6.9, 3.1), 2);
            knn.Train((5.8, 2.7), 2);
            knn.Train((6.8, 3.2), 2);
            knn.Train((6.7, 3.3), 2);
            List<((double, double), int)> list = new List<((double, double), int)>();
            list.Add(((4.8, 3.0), 0));
            list.Add(((5.1, 3.8), 0));
            list.Add(((4.6, 3.2), 0));
            list.Add(((5.3, 3.7), 0));
            list.Add(((5.0, 3.3), 0));
            list.Add(((5.7, 3.0), 1));
            list.Add(((5.7, 2.9), 1));
            list.Add(((6.2, 2.9), 1));
            list.Add(((5.1, 2.5), 1));
            list.Add(((5.7, 2.8), 1));
            list.Add(((6.7, 3.0), 2));
            list.Add(((6.3, 2.5), 2));
            list.Add(((6.5, 3.0), 2));
            list.Add(((6.2, 3.4), 2));
            list.Add(((5.9, 3.0), 2));
            Console.WriteLine((double) knn.Test(list) / list.Count);
        }
    }
}