using System;
using System.Collections.Generic;
using System.Text;

namespace vicd.app.DataStructures.BinaryTree
{
    internal class BinaryTree
    {
        public Node RootNode { get; private set; }

        public BinaryTree(Node rootNode) =>
            (RootNode) = (rootNode);

        public void PrintBinaryTree()
        {
            PrintTreeTraverse(RootNode);
        }

        private void PrintTreeTraverse(Node node)
        {
            while (node != null)
            {
                Console.WriteLine($"Pet Name: {node.PetData.Name}");

                PrintTreeTraverse(node.LeftChild);
                PrintTreeTraverse(node.RightChild);
            }
        }
    }
}
