using System;
using System.Collections.Generic;
using System.Text;

namespace vicd.app.DataStructures.Trie
{
    public class TrieAutocompleteService
    {
        private readonly Trie _trie;

        public TrieAutocompleteService()
        {
            _trie = new Trie();
            InsertWordsIntoTrie();
        }

        public List<string> GetSuggestedWords(string keyWord)
        {
            if (_trie.Search(keyWord))
                return new List<string> { keyWord };

            return default;
        }

        private void InsertWordsIntoTrie()
        {
            _trie.Insert("microsoft");
            _trie.Insert("microcomputer");
            _trie.Insert("microbiologist");
            _trie.Insert("vicluar");
            _trie.Insert("victor");
            _trie.Insert("victorinox");
        }
    }
}
