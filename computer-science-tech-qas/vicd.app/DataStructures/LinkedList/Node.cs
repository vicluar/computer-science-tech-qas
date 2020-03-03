using System;
using System.Collections.Generic;
using System.Text;

namespace vicd.app.DataStructures.LinkedList
{
    internal class Node
    {
        public Person PersonData { get; private set; }
        public Node NextNode { get; private set; }

        public Node(Person personData) =>
            (PersonData) = (personData);

        public void AssignNextNode(Node nextNode) =>
            (NextNode) = (nextNode);
    }
}
