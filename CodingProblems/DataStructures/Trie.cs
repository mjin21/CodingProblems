using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.DataStructures.Trie
{
    public class Trie
    {
        private Node Root;
        private int Depth = 0;

        public Trie()
        {
            Root = new Node((char)0);
        }
        
        public void Insert(String word)
        {
            Node current = Root;
            int wdepth = 1;
            for (int level = 0; level < word.Length; level++)
            {
                Dictionary<char, Node> children = current.Children;
                char ch = word[level];

                if (children.ContainsKey(ch))
                    current = children[ch];
                else
                {
                    Node temp = new Node(ch);
                    children.Add(ch, temp);
                    current = temp;
                }
                wdepth++;
            }
            if (wdepth > Depth)
            {
                Depth = wdepth;
            }

            current.IsEnd = true;
        }
        
        public List<string> GetMatches(String input)
        {
            return GetMatches("", input, Root.Children, new List<string>());
        }

        public List<string> GetMatches(string currentWord, string input, Dictionary<char, Node> childNodes, List<string> results)
        {
            if (childNodes == null)
                return results;

            if(input != string.Empty)
            {
                char ch = input[0];

                if (childNodes.ContainsKey(ch))
                {
                    currentWord += ch;

                    if (childNodes[ch].IsEnd)
                        results.Add(currentWord);

                    childNodes = childNodes[ch].Children;
                    return results = GetMatches(currentWord, input.Substring(1), childNodes, results);
                }
                else
                {
                    foreach (Node node in childNodes.Values)
                    {
                        if (node.IsEnd)
                            results.Add(currentWord + node.Letter);

                        results = GetMatches(currentWord + node.Letter, input.Substring(1), node.Children, results);
                    }
                }
            }
            else
            {
                foreach (Node node in childNodes.Values)
                {
                    if (node.IsEnd)
                        results.Add(currentWord + node.Letter);

                    results = GetMatches(currentWord + node.Letter, input, node.Children, results);
                }
            }

            return results;
        }
        
        public IEnumerable<string> GetWords()
        {
            List<string> result = new List<string>();
            char[] charstack = new char[Depth];
            GetWords(Root, charstack, 0, result);
            return result;
        }

        private void GetWords(Node node, char[] charstack, int stackdepth, List<string> result)
        {
            if (node == null)
            {
                return;
            }
            if (node.IsEnd)
            {
                result.Add(new string(charstack, 0, stackdepth));
            }
            foreach (Node child in node.Children.Values)
            {
                charstack[stackdepth] = child.Letter;
                GetWords(child, charstack, stackdepth + 1, result);
            }
        }
    }

    public class Node
    {
        public char Letter;
        public Dictionary<char, Node> Children;
        public bool IsEnd;

        public Node(char letter)
        {
            Letter = letter;
            Children = new Dictionary<char, Node>();
            IsEnd = false;
        }
    }
    
}
