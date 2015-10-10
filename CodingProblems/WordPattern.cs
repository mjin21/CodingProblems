using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems
{
    class WordPattern
    {
    //pattern = "abba", str = "dog cat cat dog" should return true.
    //pattern = "abba", str = "dog cat cat fish" should return false.
    //pattern = "aaaa", str = "dog cat cat dog" should return false.
    //pattern = "abba", str = "dog dog dog dog" should return false.
        public bool CheckWordPattern(string pattern, string str)
        {
            bool matchesPattern = true; 

            Dictionary<char, string> mappings = new Dictionary<char, string>();
            var strArr = str.Split(' ');

            if (pattern.Length != strArr.Length)
                return false;

            for (int i = 0; i < pattern.Length; i++)
            {
                if (!mappings.ContainsKey(pattern[i]))
                    mappings.Add( pattern[i], strArr[i] );
                else
                {
                    if (mappings[pattern[i]] != strArr[i])
                        return false;
                }
            }

            return matchesPattern;
        }
    }
}
