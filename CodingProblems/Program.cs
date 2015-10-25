using CodingProblems.DataStructures.Trie;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Trie trie = new Trie();

            var words = File.ReadAllLines(@"C:\Users\Mike\Desktop\EnglishWords.txt");
            foreach (string word in words)
                trie.Insert(word);

            var found1 = trie.GetMatches("are");
            var found2 = trie.GetMatches("ara");
            var found3 = trie.GetMatches("cae");
        }
    }
}
