using System;
using System.Collections.Generic;
using System.Text;

namespace vicd.app.DataStructures.BinarySearchTree
{
    internal class BinarySearchTree
    {
        public Node RootNode { get; private set; }

        public void Insert(int key) =>
            RootNode = AddNode(RootNode, key);

        private Node AddNode(Node root, int key)
        {
            if (root == null)
            {
                root = new Node(key);
                return root;
            }

            if (key < root.Key)
                root.AddLeftNode(AddNode(root.LeftNode, key));

            if (key > root.Key)
                root.AddRightNode(AddNode(root.RigthNode, key));

            return root;
        }
    }
}
