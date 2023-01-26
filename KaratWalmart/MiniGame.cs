using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KaratWalmart.MiniGame;

namespace KaratWalmart
{
    internal class MiniGame
    {

        public class Tip
        {
            public String Key;
            public Int32 Value;
        }

        public MiniGame()
        {


            Console.WriteLine("Walmart Karat Interview Question - MiniGame =======================================================");

            var tiles_1 = "88844";
            var tiles_2 = "99";
            var tiles_3 = "55555";
            var tiles_4 = "22333333";
            var tiles_5 = "73797439949499477339977777997394947947477993";
            var tiles_6 = "111333555";
            var tiles_7 = "42";
            var tiles_8 = "888";
            var tiles_9 = "100100000";
            var tiles_10 = "346664366";
            var tiles_11 = "8999998999898";
            var tiles_12 = "17610177";
            var tiles_13 = "600061166";
            var tiles_14 = "6996999";
            var tiles_15 = "03799449";
            var tiles_16 = "64444333355556";
            var tiles_17 = "7";
            /*tiles_1 = "88844"         # True. Base case - a pair and a triple
            tiles_2 = "99"              # True. Just a pair is enough.
            tiles_3 = "55555"           # True. The triple and a pair can be of the same tile value
            tiles_4 = "22333333"        # True. A pair and two triples
            tiles_5 = "73797439949499477339977777997394947947477993"
                                        # True. 4 has two triples and a pair, other numbers have just triples

            tiles_6 = "111333555"       # False. There are three triples, 111 333 555 but no pair
            tiles_7 = "42"              # False. Two singles not forming a pair
            tiles_8 = "888"             # False. A triple, no pair

            tiles_9 = "11 000 000 0"    # False. A pair of 1 and two triples of 0, a left over 0

tiles_10 = "33 44 666 66"   # False. Three pairs and a triple

            tiles_11 = "88 88 999 999 999"  # False. A triple of 8, three triples of 9, a leftover 8

            tiles_12 = "17610177"       # False. Triples of 1, and 7, left over 6 and 0
            tiles_13 = "600061166"      # False. A pair of 1, triple of 0, triple of 6, and 6 leftover
            tiles_14 = "6996999"        # False. A pair of 6, a triple of 9 and another pair of 9
            tiles_15 = "03799449"       # False. A pair of 4, triple of 9 and 0, 3, and 7 left over
            tiles_16 = "64444333355556" # False. A pair of 6, two pairs each of 3, 4, 5
            tiles_17 = "7"              # False. No pairs and 7 leftover
            */

            string nums = tiles_11;
            int timeCost = 0;
            Boolean basicRes = FirstWay(nums, out timeCost);

            Console.WriteLine("FirstWay");
            Console.WriteLine("Input: [" + String.Join(" , ", nums) + "]");
            Console.WriteLine("Output: [" + String.Join(" , ", basicRes) + "]");
            Console.WriteLine("Time: [" + String.Join(" , ", timeCost) + "]");
        }


        public bool FirstWay(string nums, out int timeCost)
        {
            timeCost = 0;

            nums=nums.Replace(" ", "");

            Dictionary<string, Int32> recList = nums
            .GroupBy(x => x)
            .OrderBy(x => x.Count())
            .Select(x =>
                    new
                    {
                        Key = x.Key.ToString(),
                        Value = x.Count()
                    }
            ).ToDictionary(x => x.Key, x => x.Value);


            int pair = 0;
            int triple = 0;
            int left = 0;
            foreach (KeyValuePair<string, Int32> kv in recList)
            {

                if (pair > 0) {
                    // uce bolme
                    if (kv.Value % 3 == 0)
                    {
                        triple += kv.Value / 3;
                        continue;
                    }
                }

                // ikiye bolme
                if (kv.Value % 2 == 0)
                {
                    pair += kv.Value / 2;
                    continue;
                }


                // uce bolme
                if (kv.Value % 3 == 0)
                {
                    triple += kv.Value / 3;
                    continue;
                }

                if (kv.Value > 0)
                {
                    int tmpLeft = kv.Value;
                    while (tmpLeft >= 2) { 
                        if(tmpLeft >= 3)
                        {
                            tmpLeft -= 3;
                            triple++;
                            continue;
                        }

                        if (tmpLeft >= 2)
                        {
                            tmpLeft -= 2;
                            pair++;
                            continue;
                        }
                    }
                    left += tmpLeft;

                }



            }


            Boolean result = true;
            if(pair==0)result=false;
            if(left>0) result=false;



            Console.WriteLine("Result:" + result + " Pair:" + pair + " Triple:" + triple + " Left:" + left);

            return result;
        }

    }
}