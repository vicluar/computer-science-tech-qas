using System;
using System.Collections.Generic;
using System.Text;

namespace vicd.app.DataStructures.Trie
{
    public class Trie
    {
        private Node _rootNode;

        public Trie()
        {
            _rootNode = new Node();
        }

        public void Insert(string keyWord)
        {
            var currentNode = _rootNode;

            for (int index = 0; index < keyWord.Length; index++)
            {
                var trieIndex = keyWord[index] - 'a';

                if (currentNode.ChildNodes[trieIndex] == null)
                    currentNode.ChildNodes[trieIndex] = new Node();

                currentNode = currentNode.ChildNodes[trieIndex];
            }

            currentNode.SetAsEndOfWord();
        }

        public bool Search(string keyWorkd)
        {
            var currentNode = _rootNode;

            for (int index = 0; index < keyWorkd.Length; index++)
            {
                var trieIndex = keyWorkd[index] - 'a';

                if (currentNode.ChildNodes[trieIndex] == null)
                    return false;

                currentNode = currentNode.ChildNodes[trieIndex];
            }

            return currentNode != null && currentNode.IsEndOfWord;
        }
    }
}
