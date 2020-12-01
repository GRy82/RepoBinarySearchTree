using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node
    {
        public Node rightNode;
        public Node leftNode;
        public int data;
        public Node(int data)
        {
            leftNode = null; 
            rightNode = null;
            this.data = data;
        }
        

    }
}
