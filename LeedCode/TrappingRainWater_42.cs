using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode
{
    class TrappingRainWater_42
    {
        public TrappingRainWater_42() {
            Console.WriteLine("<<== 42. Trapping Rain Water ============================================================================>>");
        

        //int[] height = new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };// 6
        int[] height = new int[] { 5, 4, 1, 2 };//

        double rec = Trap(height);

            Console.WriteLine("Input: [" + String.Join(" , ", height) + "]");
            Console.WriteLine("Output: [" + String.Join(" , ", rec) + "]");
        }

        public int Trap(int[] height) {

            int st = 0;
            int tmpRain = 0;
            int totalRain = 0;
            bool close = false;

            for (int i = 0; i < height.Length; i++) {

                if (height[i] > 0) {
                    st = height[i];

                    do {
                        tmpRain = 0;
                        close = false;

                        for (int j = i + 1; j < height.Length; j++) {
                            if (st > height[j]) {
                                tmpRain += st - height[j];
                            }
                            else {
                                totalRain += tmpRain;
                                i = j - 1;
                                close = true;
                                break;
                            }
                        }

                        if(close == false) {
                            st--;

                            if (height.Length > i+1) {
                                if (st == height[i + 1]) {
                                    break;
                                }
                            }
                        }

                    } while (st > 0 && close ==false);
                }
            }

            return totalRain;
        }
    }
}
