using System;
using System.Collections.Generic;
using System.Text;

namespace vicd.app.DataStructures.BinaryTree
{
    internal class BinaryTreeService
    {
        public void Execute()
        {
            Console.WriteLine("Kicking off the use of Binary Tree...");

            var binaryTree = GetBinaryTree();
            binaryTree.PrintBinaryTree();
        }

        private BinaryTree GetBinaryTree()
        {
            var pet1 = new Pet(1, "Gradpa", 10);
            var pet2 = new Pet(2, "Child1", 5);
            var pet3 = new Pet(3, "Child2", 5);
            var pet4 = new Pet(4, "GrandSonChild1", 3);
            var pet5 = new Pet(5, "GrandSonChild11", 3);
            var pet6 = new Pet(6, "GrandSonChild2", 3);
            var pet7 = new Pet(7, "GrandGrandSonChild1", 1);
            var pet8 = new Pet(8, "GrandGrandSonChild1", 1);
            var pet9 = new Pet(9, "GrandGrandSonChild2", 1);
            var pet10 = new Pet(10, "GrandGrandSonChild2", 1);

            var rootNode = new Node(pet1);
            var child1Node = new Node(pet2);
            var child2Node = new Node(pet3);
            var grandSonChild1 = new Node(pet4);
            var grandSonChild11 = new Node(pet5);
            var grandSonChild2 = new Node(pet6);

            grandSonChild1.AddLeftNode(new Node(pet7));
            grandSonChild1.AddRightNode(new Node(pet8));

            grandSonChild2.AddLeftNode(new Node(pet9));
            grandSonChild2.AddRightNode(new Node(pet10));

            child1Node.AddLeftNode(grandSonChild1);
            child1Node.AddRightNode(grandSonChild11);

            child2Node.AddLeftNode(grandSonChild2);

            rootNode.AddLeftNode(child1Node);
            rootNode.AddRightNode(child2Node);


            return new BinaryTree(rootNode);
        }
    }
}
