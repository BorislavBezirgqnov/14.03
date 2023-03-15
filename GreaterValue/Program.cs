using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int firstNum = int.Parse(Console.ReadLine());
                int secondNum = int.Parse(Console.ReadLine());
                int max = GetMax(firstNum, secondNum);

                Console.WriteLine(max);
            }
            else if (type == "char")
            {
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());
                char max = GetMax(firstChar, secondChar);

                Console.WriteLine(max);
            }
            else if (type == "string")
            {
                string firstLet = Console.ReadLine();
                string secondLet = Console.ReadLine();
                string max = GetMax(firstLet, secondLet);

                Console.WriteLine(max);
            }
        }

        private static int GetMax(int firstNum, int secondNum)
        {
            if (firstNum >= secondNum)
            {
                return firstNum;
            }
            else
            {
                return secondNum;
            }
        }

        private static char GetMax(char firstChar, char secondChar)
        {
            if (firstChar >= secondChar)
            {
                return firstChar;
            }
            else
            {
                return secondChar;
            }
        }

        static string GetMax(string firstString, string secondString)
        {
            if (firstString.CompareTo(secondString) >= 0)
            {
                return firstString;
            }
            else
            {
                return secondString;
            }
        }
    }
}
