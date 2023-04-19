using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lesson5_2023_04_19
{

    delegate string myDel(int _number);

    internal class Program
    {
        static string NumName(int _number)
        {
            string result = string.Empty;
            switch (_number)
            {
                case 0: result = "NULL"; Console.WriteLine(result); break;
                default: break;
            }
            return result;
        }
        static string test(int _num)
        {
            Console.WriteLine("test");
            return "test";
        }
        static void Main(string[] args)
        {
            myDel print = NumName;
            print += test;
            //print -= NumName;
            print(0);
            //Console.WriteLine(print(0));
            /* string input = "НатаШа наташа Наташа ашатан";
             if (args.Length > 0)
             {
                 input = args[0];
             }
             Regex regex = new Regex(@"(Наташа)", RegexOptions.RightToLeft);
             MatchCollection matchFind = regex.Matches(input);
             int counter = 0;
             foreach (var item in matchFind)
             {
                 Console.WriteLine($"Совпадение номер {counter} {item}");
                 counter++;
             }*/
        }
    }
}
