using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj1
{
    //A class that models a node in the binary tree
    class Node
    {

        //Contains the name of the ofthe node
        private int bossName;

        public int BossName
        {
            get { return bossName; }
            set { bossName = value; }
        }

        //Left child of a node
        private Node left;

        public Node Left
        {
            get { return left; }
            set { left = value; }
        }

        //Right child of a node
        private Node right;

        public Node Right
        {
            get { return right; }
            set { right = value; }
        }

        //Constructor for initializing the node
        public Node(int item)
        {
            bossName = item;
            left = right = null;
        }
    }
}
