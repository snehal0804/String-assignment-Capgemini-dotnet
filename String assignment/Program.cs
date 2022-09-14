using System;
using System.Security.Cryptography;

namespace String_assignment
{
    internal class Program
    {
        static void q1(string s)
        {
            Console.WriteLine(s[11]);
        }
        static void q2(string s)
        {
            Boolean result = s.Contains("is");
            Console.WriteLine(result);
        }
        static void q3(string s)
        {

            string result = s + " and killed it!";
            Console.WriteLine(result);
        }
        
        static void q4(string s)
        {
            Boolean x = s.EndsWith("dogs");
            Console.WriteLine(x);
        }
        static void q5(string s)
        {

            string s1 = "THE WUICK BROWN FOX JUMPED OVER THE LAZY DOG";
            Boolean result = s.Equals(s1);
            Console.WriteLine(result);
        }
        static void q6(string s)
        {
            Console.WriteLine(s.Length);
        }
        static void q7(string s)
        {
            string s1 = "The quick brown fox jumps over the lazy dog";
            Console.WriteLine(s.Equals(s1));
        }
        static void q8(string s)
        {
            s=s.Replace("The", "A");
            Console.WriteLine(s);
        }


        static void q9(string s)
        {
            string s1 = s.Substring(0,20);
            string s2 = s.Substring(20);
            Console.WriteLine(s2);
            Console.WriteLine(s1);
        }
        static void q10(string s)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Name of animals: ");
            string[] word_in_string = s.Split(" ");
            foreach (string val in word_in_string)
            {
                if (val == "fox" || val == "dog")
                {
                    Console.WriteLine(val);
                }
            }
        }
        static void q11(string s)
        {
            Console.WriteLine(s.ToLower());
        }
        static void q12(string s)
        {
            Console.WriteLine(s.ToUpper());
        }
        static void q13(string s)
        {
            Console.WriteLine(s.IndexOf("a"));
        }
        static void q14(string s)
        {
            Console.WriteLine(s.LastIndexOf("e"));
        }

        static void q15()
        {
            string Path =Console.ReadLine();   
            string add = @"WebApps\MyApps\Images";
            Console.WriteLine($"Tomcat Path: {Path+add}");
        }
        static void q16()
        {
            string s = @"I WANDER'D lonely as a cloud
That floats on high o'er vales and hills,

When all at once i saw a crowd
A host, of golden daffodils;beside the lake, beneath the trees
Fluttering and dancing in the breeze.";
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            string s1 = "The quick brown fox jumps over the lazy dog";
            q1(s1);
            q2(s1);
            q3(s1);
            q4(s1);
            q5(s1);
            q6(s1);
            q7(s1);
            q8(s1);
            q9(s1);
            q10(s1);
            q11(s1);
            q12(s1);
            q13(s1);
            q14(s1);
            q15();
            q16();


        }
    }
}
