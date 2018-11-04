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
        int N = int.Parse(Console.ReadLine());
        string COMPOUND = "CH3(1)CH2(1)CH3";
        int length,totalH=0,totalBond=0,totalC=0, piBond, singleBond;
        for (int i = 0; i < N; i++)
        {
            COMPOUND = Console.ReadLine();
            length = COMPOUND.Length;
            for(int j=0;j<length;j++)
            {
                if(COMPOUND[j] == 'H')
                {
                    totalH += (int)Char.GetNumericValue(COMPOUND[j+1]);;
                    totalBond += (int)Char.GetNumericValue(COMPOUND[j+1]);
                }
                else if(COMPOUND[j] == '(')
                {
                    totalBond += (int)Char.GetNumericValue(COMPOUND[j+1]);
                }
                else if(COMPOUND[j] == 'C')
                {
                    totalC += 1;
                }
            }
        }
        piBond = ( 2 * totalC - totalH ) / 2 + 1;
        singleBond = (3 * totalH ) / 2 - 2;
        
        if(totalH == ((totalC*2 + 2)-(piBond*2)))
        {
            if(totalBond == (piBond*2 + singleBond))
            {
                Console.WriteLine("VALID");
            }
            else
            {
                Console.WriteLine("INVALID");
            }
        }
        else
        {
            Console.WriteLine("INVALID");
        }
    }
}