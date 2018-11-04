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
        int N = int.Parse(Console.ReadLine()); // Number of elements which make up the association table.
        int Q = int.Parse(Console.ReadLine()); // Number Q of file names to be analyzed.
        Hashtable table = new Hashtable();
        for (int i = 0; i < N; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            table.Add(inputs[0].ToLower(),inputs[1]);
            //Console.Error.WriteLine(inputs[0].ToLower()+":"+table[inputs[0].ToLower()]+" a");
        }
        for (int i = 0; i < Q; i++)
        {
            string FNAME = Console.ReadLine();
            string []name = FNAME.Split('.');
            if(name.Length == 1)
            {
                Console.WriteLine("UNKNOWN");
            }
            else
            {
                if(table.ContainsKey(name[name.Length-1].ToLower()))
                {
                    Console.WriteLine(table[name[name.Length-1].ToLower()]);
                }
                else
                {
                    Console.WriteLine("UNKNOWN");
                }
            }
        }
    }
}