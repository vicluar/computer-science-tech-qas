using System;
using System.Collections.Generic;
using vicd.app.DataStructures.BinaryTree;
using vicd.app.DataStructures.LinkedList;
using vicd.app.DataStructures.Trie;

namespace vicd.app
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecuteTrieAutocompleteService();
        }

        private static void ExecuteTrieAutocompleteService()
        {
            Console.WriteLine("Type your word...");
            var keyWord = Console.ReadLine();

            var trieAutocompleteService = new TrieAutocompleteService();
            var suggestedWords = trieAutocompleteService.GetSuggestedWords(keyWord);

            if (suggestedWords == null || suggestedWords.Count <= 0)
            {
                Console.WriteLine("No suggested words");
                return;
            }
                
            PrintSuggestedWords(suggestedWords);
        }

        private static void PrintSuggestedWords(List<string> suggestedWords)
        {
            Console.WriteLine("Suggested words...");
            foreach (var word in suggestedWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}
