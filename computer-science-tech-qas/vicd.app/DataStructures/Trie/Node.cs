using System;
using System.Collections.Generic;
using System.Text;

namespace vicd.app.DataStructures.Trie
{
    public class Node
    {
        private const int ALPHABET_SIZE = 26;

        public Node[] ChildNodes { get; private set; }
        public bool IsEndOfWord { get; private set; }

        public Node()
        {
            ChildNodes = new Node[ALPHABET_SIZE];
            IsEndOfWord = false;
        }

        public void SetAsEndOfWord()
        {
            IsEndOfWord = true;
        }
    }
}
