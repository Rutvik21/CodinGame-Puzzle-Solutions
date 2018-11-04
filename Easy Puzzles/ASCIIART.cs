using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        int L = int.Parse(Console.ReadLine());
        int H = int.Parse(Console.ReadLine());
        string T = Console.ReadLine();
        char [,]asciiART = new char[H,27*L];
        int i,j,m,k;
        for (i = 0; i < H; i++)
        {
            char []ROW = Console.ReadLine().ToCharArray();
            for(j=0;j<27*L;j++){
                asciiART[i,j] = ROW[j];
            }
        }
        T = T.ToUpper();
        for(i=0;i<H;i++){
            for(j=0;j<T.Length;j++){
                m = Convert.ToInt32(T[j]) - 65;
                if(!Char.IsLetter(T[j])){
                    for(k=26*L;k!=26*L + L;k++){
                        Console.Write(asciiART[i,k]);
                    }
                }else{
                    for(k=m*L;k!=m*L + L;k++){
                        Console.Write(asciiART[i,k]);
                    }
                }
            }
            Console.WriteLine();
        }
    }
}