using System;
using System.Text;

namespace vicd.app.DataStructures.LinkedList
{
    internal class LinkedList
    {
        public Node HeadNode { get; private set; }

        public LinkedList(Node headNode) =>
            (HeadNode) = (headNode);

        public void PrintLinkedList()
        {
            var currentNode = HeadNode;
            var stringBuilder = new StringBuilder();

            while (currentNode != null)
            {
                stringBuilder.Append($"Person data => Id: {currentNode.PersonData.Id} -- ");
                stringBuilder.Append($"FirstName: {currentNode.PersonData.FirstName} -- ");
                stringBuilder.Append($"LastName: {currentNode.PersonData.LastName} ");

                Console.WriteLine(stringBuilder.ToString());
                
                stringBuilder.Clear();
                currentNode = currentNode.NextNode;
            }
        }
    }
}
