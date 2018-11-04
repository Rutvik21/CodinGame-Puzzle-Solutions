using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        string equality = Console.ReadLine();
        Solution obj = new Solution();
        string []s = Regex.Split(equality, "[+=]");
        for(int i=2;i<=36;i++){
            double x = obj.convert(s[0],i);
            double y = obj.convert(s[1],i);
            double z = obj.convert(s[2],i);
            if(x!=-1 && y!=-1 && z!=-1 && x+y==z){
                Console.WriteLine(i);
                break;
            }
        }
    }
    
    double convert(string str, int b){
        string bases = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        double sum = 0;
        for(int i=0;i<str.Length;i++){
            int index = bases.IndexOf(str[i]);
            if(index == -1 || index >= b)
            {
                return -1;
            }
            sum *= b;
            sum += index;
        }
        return sum;
    }
}