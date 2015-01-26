using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Common;

namespace Problems
{
    public class Problem22 : IProblem
    {
        public long Solve()
        {
            var content = GetContent();
            var contentSplit = content.Split(',');
            var names = new List<string>(contentSplit.Count());

            foreach (var element in contentSplit)
            {
                var name = element.Substring(1, element.Count() - 2);
                names.Add(name);
            }

            names.Sort();
            var valueOfA = Convert.ToInt64('A');
            long result = 0;

            for (var i = 0; i < names.Count; i++)
            {
                var value = names[i].Sum(x => Convert.ToInt64(x) - valueOfA + 1);
                long weight = i + 1;
                result += value*weight;
            }

            return result;
        }

        public static string GetContent()
        {
            var assembly = Assembly.GetExecutingAssembly(); ;
            var stream = assembly.GetManifestResourceStream("Problems.p022_names.txt");
            var streamReader = new StreamReader(stream);
            return streamReader.ReadToEnd();
        }
    }
}
