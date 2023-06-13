using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4B_OOP_Problem
{
    internal class StringWordReverser
    {
        private string input;

        public StringWordReverser(string input)
        {
            this.input = input;
        }

        public string ReverseWords()
        {
            string[] words = input.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                char[] charArray = words[i].ToCharArray();
                Array.Reverse(charArray);
                words[i] = new string(charArray);
            }

            return string.Join(" ", words);
        }
    }
}
