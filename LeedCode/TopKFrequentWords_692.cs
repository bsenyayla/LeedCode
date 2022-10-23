using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode
{
    class TopKFrequentWords_692
    {

        public TopKFrequentWords_692() {
            Console.WriteLine("<<== Rotate Array 189 ============================================================================>>");

            string[] val1 = new string[] { "i", "love", "leetcode", "i", "love", "coding" };
            string[] val2 = new string[] { "the", "day", "is", "sunny", "the", "the", "the", "sunny", "is", "is" };

            IList<string> rec=TopKFrequent(val1
                                            ,3);

            Console.WriteLine("Input: [" + String.Join(" , ", val1) + "] , k=3");
            Console.WriteLine("Output: [" + String.Join(" , ", rec) + "]");
        }

        public IList<string> TopKFrequent(string[] words, int k) {
            Console.WriteLine("Way 1 ============");

            var results = words
                .GroupBy(x => x)
                //.Where(x => x.Count() > 1)
                .Select(std => new
                {
                    Key = std.Key,
                    //Sorting the data based on name in descending order
                    KeyCount = std.Count()
                })
                .OrderByDescending(x => x.KeyCount).ThenBy(x => x.Key)
                .Take(k)
                ;

            return results.Select(x=>x.Key).ToList();
        }

    }
}

