using System;
using System.Collections.Generic;
using System.Text;

namespace vicd.app.DataStructures.Trie
{
    public class TrieAutocompleteService
    {
        public List<string> GetSuggestedWords(string keyWord)
        {
            return new List<string>
            {
                "microsoft",
                "microcomputer",
                "microbiologist"
            };
        }
    }
}
