﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrappingRainWaterProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] height = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            int[] height2 = { 4, 2, 0, 3, 2, 5 };
            Console.WriteLine(Trap(height));
            Console.WriteLine(Trap(height2));
        }


        static int Trap(int[] height)
        {
            int n = height.Length;
            if (n <= 2)
                return 0;

            int left = 0, right = n - 1;
            int leftMax = 0, rightMax = 0;
            int trappedWater = 0;

            while (left < right)
            {
                if (height[left] < height[right])
                {
                    if (height[left] > leftMax)
                        leftMax = height[left];
                    else
                        trappedWater += leftMax - height[left];
                    left++;
                }
                else
                {
                    if (height[right] > rightMax)
                        rightMax = height[right];
                    else
                        trappedWater += rightMax - height[right];
                    right--;
                }
            }

            return trappedWater;
        }
    }
}
