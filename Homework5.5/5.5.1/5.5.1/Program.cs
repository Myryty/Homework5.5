using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._5._1
{
    class Program
    {
        static void Pause()
        {
            Console.ReadKey();
        }
        static void EnterTextPhrase()
        {
            Console.WriteLine("Введите любое предложение (слова разделены пробелом): ");
        }
        static string[] SplitText(string text)
        {
            return text.Split(' ');
        }
        static void PrintWords(string[] words)
        {
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
        static void Main(string[] args)
        {
            EnterTextPhrase();
            string text = Convert.ToString(Console.ReadLine());
            string[] words = SplitText(text);
            PrintWords(words);
            Pause();
        }
    }
}
