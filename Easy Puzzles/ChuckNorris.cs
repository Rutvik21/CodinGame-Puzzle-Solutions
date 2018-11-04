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
        string MESSAGE = Console.ReadLine();
        string binary = "";
        string temp="",binaryT="";
        int i,j,c=1;
        for(i=0;i<MESSAGE.Length;i++){
            binaryT = Convert.ToString(MESSAGE[i],2);
            if(binaryT.Length<7){
                binary = binary+"0"+binaryT;
            }else{
                binary = binary + binaryT;
            }
        }
        
        for(i=0;i<binary.Length-1;i++){
            if(binary[i]!=binary[i+1]){
                c++;
            }
        }
        j=0;
        string []box = new string[c];
        for(i=0;i<binary.Length-1;i++){
            box[j]+=binary[i];
            if(binary[i]!=binary[i+1]){
                j++;
            }
        }
        box[j] += binary[binary.Length-1];
        for(i=0;i<c;i++){
            temp = box[i];
            if(temp[0] == '1'){
                Console.Write(0+" ");
                for(j=0;j<temp.Length;j++){
                    Console.Write(0);
                }
                if(i!=c-1)
                    Console.Write(" ");
            }
            else
            {
                Console.Write("00 ");
                for(j=0;j<temp.Length;j++){
                    Console.Write(0);
                }
                if(i!=c-1)
                    Console.Write(" ");
            }
        }
    }
}