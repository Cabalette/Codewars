using System.Numerics;
using System;
using System.Reflection;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WordSpinner("aaab bc ccccccd"));
            int a = 3;
        }

        static string WordSpinner(string sentence)
        {
            return String.Join(" ", (sentence.Split(' ').
                         Select(x =>
                         {
                             if (x.Length > 4)
                             {
                                 char[] sReverse = x.ToCharArray();
                                 Array.Reverse(sReverse);
                                 x = new string(sReverse);
                             }
                             return x;
                         }).                         
                         ToArray()));
        }
    }
    }
