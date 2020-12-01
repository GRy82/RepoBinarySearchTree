using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        Node rootNode = null;

        public void Add(Node addedNode)
        {
            if (rootNode == null) {//if the first node.
                rootNode = addedNode;
            }
            else { //if a subsequent node to the root. 
                Node currentNode = rootNode;
                Node lastNode = currentNode;
                while (lastNode != null) 
                {
                    currentNode = AssessNodeEdges(addedNode.data, currentNode);
                    if (currentNode == null) {
                        currentNode = addedNode;
                        if (currentNode.data <= lastNode.data) {
                            lastNode.leftNode = currentNode;
                        }
                        else {
                            lastNode.rightNode = currentNode;
                        }
                        lastNode = null;
                    }
                    else{
                        lastNode = currentNode;
                    }
                } 
            }
        }


        public bool Search()
        {
            int data = InputSearch();
            Node currentNode = rootNode;
            while (currentNode != null)
            {
                if (currentNode.data == data) {
                    Console.WriteLine("That data was found.");
                    return true;
                }
                else {
                    currentNode = AssessNodeEdges(data, currentNode);
                }
            }
            return false;
        }

        private int InputSearch()
        {
            Console.Write("Enter data to be searched for: ");
            string dataInput = Console.ReadLine();
            int data = Convert.ToInt32(dataInput);
            return data;
        }

        private Node AssessNodeEdges(int assessedNodeData, Node counterNode)
        {
            if (assessedNodeData <= counterNode.data) { 
                counterNode = counterNode.leftNode;
            }
            else {
                counterNode = counterNode.rightNode;
            }
            return counterNode;
        }




       
    }
}
