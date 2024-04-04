using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._5._2
{
    class Program
    {
        static void Pause()
        {
            Console.ReadKey();
        }
        static string ReverseWords(string inputPhrase)
        {
            string[] words = SplitText(inputPhrase);
            Array.Reverse(words);
            string reversedPhrase = JoinText(words);
            return reversedPhrase;
        }
        static string[] SplitText(string text)
        {
            return text.Split(' ');
        }
        static string JoinText(string[] words)
        {
            return string.Join(" ", words);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            string inputPhrase = Console.ReadLine();
            string reversedPhrase = ReverseWords(inputPhrase);
            Console.WriteLine("Предложение задом наперед:");
            Console.WriteLine(reversedPhrase);
            Pause();
        }


    }
}
