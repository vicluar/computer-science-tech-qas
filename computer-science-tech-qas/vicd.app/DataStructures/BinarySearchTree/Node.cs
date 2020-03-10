using System;
using System.Collections.Generic;
using System.Text;

namespace vicd.app.DataStructures.BinarySearchTree
{
    internal class Node
    {
        public int Key { get; private set; }
        public Node LeftNode { get; private set; }
        public Node RigthNode { get; private set; }

        public Node(int key) =>
            (Key) = (key);

        public void AddLeftNode(Node node) =>
            (LeftNode) = (node);

        public void AddRightNode(Node node) =>
            (RigthNode) = (node);
    }
}
