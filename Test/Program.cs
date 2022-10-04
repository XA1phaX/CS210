// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace test
{
    
    class Program
    {     
    static Dictionary<int, List<int>> WinConditions = new Dictionary<int, List<int>>()
    {
        { 1, new List<int>() {1, 2, 3 } },
        { 2, new List<int>() {4, 5, 6 } },
        { 3, new List<int>() {7, 8, 9 } },
        { 4, new List<int>() {1, 4, 7 } },
        { 5, new List<int>() {2, 5, 8 } },
        { 6, new List<int>() {3, 6, 9 } },
        { 7, new List<int>() {1, 5, 9 } },
        { 8, new List<int>() {3, 5, 7 } }
    };


    static void Main(string[] args)
    {
        checkDictionary();
    }

    public static void checkDictionary()
    {
        foreach (KeyValuePair<int, List<int>> entry in WinConditions)
        {
            // Console.WriteLine("Key = {0}, Value = {1}", entry.Key, entry.Value);
            Console.WriteLine(entry.Value[1]);
        }

        // for (var i = 1; i < WinConditions.Count; i++) 
        // {
        //     Console.WriteLine("Key = is {0}, Value = {1}", WinConditions[i], WinConditions.Values);
        // }
    }
    }

}
    



