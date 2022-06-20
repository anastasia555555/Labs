using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //№1
            List<int> one = new List<int> { 1, 3, 4, -12, 3, 4, 4, 0, 1, 4, 1 };
            int pairsCount = 0;
            try
            {
                while (one.Count > 0)
                {
                    int i = one[0];
                    var pairs = one.FindAll(next => next == i);
                    pairsCount += pairs.Count / 2;
                    one.RemoveAll(next => next == i);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Pairs={0}", pairsCount);
            Console.WriteLine("----------------------");

            //№2
            Dictionary<int, int> two = new Dictionary<int, int>() 
            {
                {1, 15},
                {2, -70 },
                {3, 948 },
                {4, 39 },
                {5, -47 },
                {6, -70 }
            };
            try
            {
                Dictionary<string, int> results = new Dictionary<string, int>();
                results.Add("max", two.Values.Max());
                results.Add("min", two.Values.Min());

                string json = JsonConvert.SerializeObject(results);
                Console.WriteLine(json);
                
                JsonSerializer serializer = new JsonSerializer();
                using (StreamWriter sw = new StreamWriter(@"C:\Users\Admin\Documents\КПІ\Prog\json.txt"))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, results);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Список пустий");
            }
            Console.WriteLine("----------------------");
            



            //№3
            List<int> three = new List<int> { -109, 109, 23, -87, 0, 1, 18, 23, 12, 8, 1};
            //var numbers3 = from i in three
              //            where i % 2 == 0
                //          select i;

            var numbers3 = three.Where(i => i % 2 != 0);
            var numbers31 = numbers3.Distinct();
            foreach(int i in numbers31)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine("\n----------------------");

        }
    }
}
