using System;
using vicd.app.DataStructures.BinaryTree;
using vicd.app.DataStructures.LinkedList;

namespace vicd.app
{
    class Program
    {
        static void Main(string[] args)
        {
            var binaryTreeService = new BinaryTreeService();
            binaryTreeService.Execute();

            //var linkedListService = new LinkedListService();
            //linkedListService.Execute();
        }
    }
}
