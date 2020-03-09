using System;
using System.Collections.Generic;
using System.Text;

namespace vicd.app.DataStructures.BinaryTree
{
    internal class Node
    {
        public Pet PetData { get; set; }
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }

        public Node(Pet petData) =>
            (PetData) = (petData);

        public void AddRightNode(Node node) =>
            (RightChild) = (node);

        public void AddLeftNode(Node node) =>
            (LeftChild) = (node);
    }
}
