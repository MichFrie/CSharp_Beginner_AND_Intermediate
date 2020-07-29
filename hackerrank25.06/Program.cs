using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the breakingRecords function below.
    static int[] breakingRecords(int[] scores)
    {
        int maxChanged = 0, minChanged = 0;
        int max = int.MinValue, min = int.MaxValue;

		for (int i = 0; i < scores.Length; i++)
		{
			if (i == 0)
			{
                max = scores[i];
                min = scores[i];
			}
			else if (scores[i] > max)
			{
                max = scores[i];
                maxChanged++;
			}
			else if (scores[i] < min)
			{
                min = scores[i];
                minChanged++;
			}
		}
        return new int[2] { maxChanged, minChanged };
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp));

        int[] result = breakingRecords(scores);

        Console.WriteLine(string.Join(" ", result));

        
    }
}
