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

class Result
{

    /*
     * Complete the 'checkMagazine' function below.
     *
     * The function accepts following parameters:
     *  1. STRING_ARRAY magazine
     *  2. STRING_ARRAY note
     */

    public static void checkMagazine(List<string> magazine, List<string> note)
    {
        Dictionary<string, int> magazine_dictionary = new Dictionary<string, int>();
        Dictionary<string, int> note_dictionary = new Dictionary<string, int>();
        
        foreach(var m in magazine) {
            if(!magazine_dictionary.ContainsKey(m))
                magazine_dictionary.Add(m, 1);
            else   
                magazine_dictionary[m] = magazine_dictionary[m] + 1;
        }
        
        foreach(var n in note) {
            if(!note_dictionary.ContainsKey(n))
                note_dictionary.Add(n, 1);
            else  
                note_dictionary[n] = note_dictionary[n] + 1;
        }
        
        foreach(var word in note) {
            if(!magazine_dictionary.ContainsKey(word)) {
                Console.Write("No");
                return;
            }
            
            if(magazine_dictionary[word] < note_dictionary[word]) {
                Console.Write("No");
                return;
            }
        }
        Console.Write("Yes");   
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int m = Convert.ToInt32(firstMultipleInput[0]);

        int n = Convert.ToInt32(firstMultipleInput[1]);

        List<string> magazine = Console.ReadLine().TrimEnd().Split(' ').ToList();

        List<string> note = Console.ReadLine().TrimEnd().Split(' ').ToList();

        Result.checkMagazine(magazine, note);
    }
}
