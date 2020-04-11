using System;
using vicd.app.DataStructures.BinaryTree;
using vicd.app.DataStructures.LinkedList;
using vicd.app.DataStructures.Trie;

namespace vicd.app
{
    class Program
    {
        static void Main(string[] args)
        {
            var trieService = new TrieService();
            trieService.Execute();

            //Testing("abcdefghijklm");

            //var binaryTreeService = new BinaryTreeService();
            //binaryTreeService.Execute();

            //var linkedListService = new LinkedListService();
            //linkedListService.Execute();
        }

        //static void Testing(string key)
        //{
        //    int index;
        //    int lenght = key.Length;

        //    for (int level = 0; level < lenght; level++)
        //    {
        //        index = key[level] - 'a';
        //        Console.WriteLine(index);
        //    }

        //    Console.Read();
        //}
    }
}
