using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int []pi = new int[N];
        int c=0;
        int i,j,minDiff=Int32.MaxValue;
        for (i = 0; i < N; i++)
        {
            pi[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(pi);
        for(i=0;i<N-1;i++){
            if(pi[i+1]-pi[i] < minDiff){
                minDiff = pi[i+1]-pi[i];
            }
        }
        Console.WriteLine(minDiff);
    }
}