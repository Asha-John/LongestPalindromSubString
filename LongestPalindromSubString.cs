using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace LongestPalindromSubString
{
    public class FindPalidromSubString
    {
        public static void Main(String[] args)
        {
            Console.Write("Please Enter your main string : ");
            string mainstring = Console.ReadLine();
            string _substring= PalindromSubString.longestPalSubstr(mainstring);
        }
    }
}