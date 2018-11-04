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
        string LON = Console.ReadLine();
        string LAT = Console.ReadLine();
        double longitudeA = (Convert.ToDouble(LON.Replace(',','.'))*Math.PI)/180;
        double latitudeA = (Convert.ToDouble(LAT.Replace(',','.'))*Math.PI)/180;
        double x,y,d,longitudeB,latitudeB, minD = Double.MaxValue;
        int minIndex = -1;
        int N = int.Parse(Console.ReadLine());
        int i;
        string []details = new string[N];
        for (i = 0; i < N; i++)
        {
            details[i] = Console.ReadLine();
        }
        for(i=0;i<N;i++){
            string []str = details[i].Split(';');
            longitudeB = (Convert.ToDouble(str[4].Replace(',','.'))*Math.PI)/180;
            latitudeB = (Convert.ToDouble(str[5].Replace(',','.'))*Math.PI)/180;
            x = (longitudeB-longitudeA)*Math.Cos((latitudeA+latitudeB)/2);
            y = (latitudeB - latitudeA);
            d = Math.Sqrt(Math.Pow(x,2)+Math.Pow(y,2)) * 6371;
            if(d < minD){
                minD = d;
                minIndex = i;
            }
        }
        string []str1 = details[minIndex].Split(';');
        Console.WriteLine(str1[1]);
    }
}