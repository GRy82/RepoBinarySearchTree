﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node
    {
        public Node nextNode;
        public int data;
        public Node(int data)
        {
            nextNode = null;
            this.data = data;
        }
        

    }
}
