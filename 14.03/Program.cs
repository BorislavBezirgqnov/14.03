using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace _14._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи тип: ");
            string type = Console.ReadLine();
            if (type =="int")
            {
                Console.Write("Въведи първото число: ");
                int first = int.Parse(Console.ReadLine());
                Console.Write("Въведи второ числло: ");
                int second = int.Parse(Console.ReadLine());
                int max = GetMax(first, second);
                Console.WriteLine($"ПО големия символ е {(char)max}");
            }
            else if (type =="string")
            {
                Console.Write("Въведи първи низ от символи: ");
                string fitst = Console.ReadLine();
                Console.Write("Въведи втроив низ от символи: ");
                string second =(Console.ReadLine());
                string max = GetMax(fitst, second);
                Console.WriteLine($"По големия символ е {max}");
            }
            else if (type == "char")
            {
                Console.Write("Въведи първия низ от символи: ");
                char first = char.Parse(Console.ReadLine());
                Console.Write("Въведи втроия низ от символи: ");
                char second = char.Parse(Console.ReadLine());
                int max = GetMax(first, second);
                Console.WriteLine($"По големия низ от символи е {max}");
            }
            

            
        }
        private static string GetMax(string first, string second)
        {
            string result = "";
            if (first.CompareTo(second) >= 0)
            {
                result = first;
                return result;
            }
            else
            {
                result = second;
                return result;
             }

        }
        private static int GetMax(char first, char second)
        {
            string result = 0;
            if ((int)first>(int) second)
            {
                result = first;
                return result;
            } 
            else
            {
                result = second;
                return result;
            }
        }

}
