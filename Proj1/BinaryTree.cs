using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj1
{
    class BinaryTree
    {
        // static Boolean isFound = false;
        //static Boolean isFound2 = false;

        private Node top;

        public Node Top
        {
            get { return top; }
            set { top = value; }
        }

        public BinaryTree()
        {
            top = null;
        }

        public BinaryTree(string value)
        {
            top = new Node(value);
        }


        public Node CommonBoss(Node node, string n1, string n2)
        {

            while (node != null)
            {
                if (node.BossName == n1)
                {
                    //isFound = true;
                    return node;
                }

                if (node.BossName == n2)
                {
                    //isFound2 = true;
                    return node;
                }

                Node left = CommonBoss(node.Left, n1, n2);
                Node right = CommonBoss(node.Right, n1, n2);

                if (left == null && right == null)
                {
                    return null;
                }

                if (left != null && right != null)
                {
                    return node;
                }

                if (left != null)
                {
                    return left;
                }

                if (right != null)
                {
                    return right;
                }
            }
            return null;
        }

        public Node EnterBoss(string n1, string n2)
        {
            //isFound = false;
            //isFound2 = false;

            /*Node contain =*/
            return CommonBoss(Top, n1, n2);

            /*if (isFound == true && isFound2 == true)
            {
                return contain;
            }
            else
            {
                return null;
            }*/
        }

        public void AddNode(string value)
        {
            Node currNode = Top;
            bool added = false;
            do
            {
                if (currNode.Right == null)
                {
                    Node newNode = new Node(value);
                    currNode.Right = newNode;
                    added = true;
                }
                else
                {
                    currNode = currNode.Right;
                }
                if (currNode.Left == null)
                {
                    Node newNode = new Node(value);
                    currNode.Left = newNode;
                    added = true;
                }
                else
                {
                    currNode = currNode.Left;
                }
            }
            while (!added);
        }
    }

}