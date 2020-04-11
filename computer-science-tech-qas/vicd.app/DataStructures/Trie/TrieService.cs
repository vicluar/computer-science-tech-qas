using System;
using System.Collections.Generic;
using System.Text;

namespace vicd.app.DataStructures.Trie
{
    public class TrieService
    {
        private List<string> _wordsToUse;
        private Trie _trie;

        public TrieService()
        {
            _trie = new Trie();

            _wordsToUse = new List<string>
            {
                "billions",
                "bobby",
                "axelrod",
                "chuck",
                "rhodes",
                "wendy",
                "rhodes"
            };
        }

        public void Execute()
        {
            InsertWords();
            SearchWords();
        }

        private void InsertWords()
        {
            foreach (var word in _wordsToUse)
            {
                _trie.Insert(word);
                Console.WriteLine($"Word ==> {word} inserted.");
            }
        }

        private void SearchWords()
        {
            foreach (var word in _wordsToUse)
            {
                Console.WriteLine($"{word} ==> {_trie.Search(word)}");
            }

            Console.WriteLine($"ramdom ==> {_trie.Search("ramdom")}");
            Console.WriteLine($"welcome ==> {_trie.Search("welcome")}");
            Console.WriteLine($"axe ==> {_trie.Search("axe")}");
        }
    }
}
