using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void ReverseWord(string word)
            {
                Stack<char> stack = new Stack<char>();
                char c;
                for (int i = 0; i < word.Length; i++)
                {
                    c = word[i];
                    stack.Push(c);
               

                }
                string reverseword = string.Empty;
                while (stack.Count > 0)
                {
                    reverseword += stack.Pop();
                }
                Console.WriteLine(reverseword);
            }
            ReverseWord("Salam");
        }
    }
}
