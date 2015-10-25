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

        public Trie()
        {
            Root = new Node((char)0);
        }
        
        public void Insert(String word)
        {
            Node current = Root;
            
            for (int level = 0; level < word.Length; level++)
            {
                Dictionary<char, Node> children = current.Children;
                char ch = word[level];

                // If there is already a child for current character of given word
                // Else create a child 
                if (children.ContainsKey(ch))
                    current = children[ch];
                else        
                {
                    Node temp = new Node(ch);
                    children.Add(ch, temp);
                    current = temp;
                }
            }

            // set last node/char as the end
            current.IsEnd = true;
        }

        //public List<string> GetMatches(String input)
        //{
        //    var results = new List<string>();
        //    String result = ""; // Initialize resultant string    

        //    Node current = Root;

        //    for (int level = 0; level < input.Length; level++)
        //    {
        //        char ch = input[level];

        //        Dictionary<char, Node> children = current.Children;

        //        if (children.ContainsKey(ch))
        //        {
        //            result += ch;          //Update result
        //            current = children[ch]; //Update crawl to move down in Trie

        //            if (current.IsEnd)
        //                results.Add(result);
        //        }
        //        else if (!children.ContainsKey(ch))
        //        {
        //            results = GetMatchesRecursive(result, input.Substring(level), current, results);
        //        }
        //    }

        //    return results;
        //}

        //public List<string> GetMatchesRecursive(string currentWord, string input, Node node, List<string> results)
        //{
        //    string result = currentWord;
        //    Node current = node;

        //    if (input == string.Empty)
        //        return results;

        //    char ch = input[0];
        //    Dictionary<char, Node> children = current.Children;
        //    if (children.ContainsKey(ch))
        //    {
        //        result += ch;          
        //        current = children[ch];

        //        if (current.IsEnd)
        //            results.Add(result);

        //        return results = GetMatchesRecursive(currentWord, input.Substring(1), current, results);
        //    }
        //    else
        //    {
        //        foreach(KeyValuePair<char, Node> child in children)
        //        {
        //            if (child.Value.IsEnd)
        //                results.Add(result + child.Value.Letter);

        //            results = GetMatchesRecursive(currentWord, input.Substring(1), child.Value, results);
        //        }
        //    }

        //    return results;
        //}
        
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
        //public List<string> GetMatches(string currentWord, string input, Dictionary<char, Node> childNodes, List<string> results)
        //{
        //    if (childNodes == null || input == string.Empty)
        //        return results;

        //    char ch = input[0];

        //    if (childNodes.ContainsKey(ch))
        //    {
        //        currentWord += ch;

        //        if (childNodes[ch].IsEnd)
        //            results.Add(currentWord);

        //        childNodes = childNodes[ch].Children;
        //        return results = GetMatches(currentWord, input.Substring(1), childNodes, results);
        //    }
        //    else
        //    {
        //        foreach (Node node in childNodes.Values)
        //        {
        //            if (node.IsEnd)
        //                results.Add(currentWord + node.Letter);

        //            results = GetMatches(currentWord + node.Letter, input.Substring(1), node.Children, results);
        //        }
        //    }

        //    return results;
        //}

        //public List<string> GetMatches(string currentWord, string input, Node node, List<string> results)
        //{
        //    if (node == null || input == string.Empty)
        //        return results;

        //    char ch = input[0];
        //    Dictionary<char, Node> children = node.Children;
        //    if (children.ContainsKey(ch))
        //    {
        //        currentWord += ch;
        //        node = children[ch];

        //        if (node.IsEnd)
        //            results.Add(currentWord);

        //        return results = GetMatches(currentWord, input.Substring(1), node, results);
        //    }
        //    else
        //    {
        //        foreach (Node child in children.Values)
        //        {
        //            if (child.IsEnd)
        //                results.Add(currentWord + child.Letter);

        //            results = GetMatches(currentWord, input.Substring(1), child, results);
        //        }
        //    }

        //    return results;
        //}
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
