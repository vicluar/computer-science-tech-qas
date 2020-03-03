using System;

namespace vicd.app.DataStructures.LinkedList
{
    internal class LinkedListService
    {
        public void Execute()
        {
            Console.WriteLine("Kicking off the use of LinkedList");

            LinkedList linkedList = SetUpLinkedList();

            linkedList.PrintLinkedList();
        }

        private LinkedList SetUpLinkedList()
        {
            var firstNode = new Node(new Person(1, "First", "Person"));
            var secondNode = new Node(new Person(2, "Second", "Person"));
            var thirdNode = new Node(new Person(3, "Third", "Person"));
            var fourthNode = new Node(new Person(4, "Fourth", "Person"));
            var fifthNode = new Node(new Person(5, "Fifth", "Person"));

            firstNode.AssignNextNode(secondNode);
            secondNode.AssignNextNode(thirdNode);
            thirdNode.AssignNextNode(fourthNode);
            fourthNode.AssignNextNode(fifthNode);

            return new LinkedList(firstNode);
        }
    }
}
