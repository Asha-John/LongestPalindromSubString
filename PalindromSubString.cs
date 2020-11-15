
using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
namespace LongestPalindromSubString
{
   public class PalindromSubString
    {
       public static void printSubStr(string str, int low, int high) 
        { 
          Console.WriteLine(str.Substring(low, (high + 1) - low)); 
        } 
  
        public static string longestPalSubstr(string str) 
        { 
           
            int maxLength = 1; 
  
            int start = 0; 
            int len = str.Length; 
  
            int low=0;
            int high=0; 
  
              //  consider each  character as center point of even and length palindromes 
                for (int i = 1; i < len; ++i) 
                { 
                         // Find the longest even length  palindrome with center points as i-1 and i. 
                         low = i - 1; 
                         high = i; 
                             while (low >= 0 && high < len && str[low] == str[high]) 
                             { 
                                 if (high - low + 1 > maxLength) 
                                 { 
                                 start = low; 
                                  maxLength = high - low + 1; 
                                 } 
                                 --low; 
                                 ++high; 
                            } 
             // Find the longest odd length palindrome with center point as i 
                         low = i - 1; 
                         high = i + 1; 
                         while (low >= 0 && high < len && str[low] == str[high]) 
                         { 
                             if (high - low + 1 > maxLength) 
                             { 
                                  start = low; 
                                  maxLength = high - low + 1; 
                            } 
                            --low; 
                            ++high; 
                         } 
                } 
  
            Console.Write("Longest palindrome substring is: "); 
              printSubStr(str, start, start + maxLength - 1); 
  
                return null;
        }
    }
}