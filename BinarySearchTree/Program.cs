using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node node1 = new Node(45);
            Node node2 = new Node(42);
            Node node3 = new Node(43);
            Node node4 = new Node(46);
            Node node5 = new Node(48);
            Node node6 = new Node(47);
            Node node7 = new Node(49);


            BinarySearchTree binaryTree = new BinarySearchTree();
            binaryTree.Add(node1);
            binaryTree.Add(node2);
            binaryTree.Add(node3);
            binaryTree.Add(node4);
            binaryTree.Add(node5);
            binaryTree.Add(node6);
            binaryTree.Add(node7);

            binaryTree.Search();
            Console.ReadLine();
        }
    }
}
