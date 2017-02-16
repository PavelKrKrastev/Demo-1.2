using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj1
{
    //Class that models the Binary tree
    class BinaryTree
    {
        //The first node in the tree(root of the tree)
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

        public BinaryTree(int value)
        {
            top = new Node(value);
        }

        //Finds the lowest common antsestor(LCA) of two given nodes in the tree
        //node is the root of the tree, n1 and n2 are the names of the people entered to find LCA 
        public Node CommonBoss(Node node, int n1, int n2)
        {
            //We search for the LCA as long as the root element is different from null
            while (node != null)
            {
                //Check to see if the entered name maches the top node
                if (node.BossName == n1)
                {
                    //If it does match we know that the entered name is present in the tree and then return the node
                    return node;
                }

                //Check to see if the entered name maches the top node and return the node
                if (node.BossName == n2)
                {
                    //If it does match we know that the entered name is present in the tree
                    return node;
                }

                //If the names don't match the top node useing recursion we start trasersing 
                //the left side of the root and then the right side of the root
                //passing the same strings as the names we are looking for.
                //We have two nodes left and right for every node
                Node left = CommonBoss(node.Left, n1, n2);
                Node right = CommonBoss(node.Right, n1, n2);

                //If both left and right return a null we know that this node is not the LCA.
                if (left == null && right == null)
                {
                    return null;
                }

                //If both nodes left and right are not null. This means that the current node we are on is the LCA.
                if (left != null && right != null)
                {
                    return node;
                }

                //If no of the above criteria are met we return the node that is !=0
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

        //This function is used to check if
        //both names are present in the tree,
        //and simplify entering values once we are in the main function
        public Node EnterBoss(int n1, int n2)
        {
            return CommonBoss(Top, n1, n2);
        }

        //Function that adds nodes to the tree with the given input value
        public void AddNode(int value)
        {
            //Local variable to store on which node the loop is to define where to insert the node
            Node currNode = Top;
            //Loop until the node is intered in the tree
            bool added = false;
            //Run the loop until all of the nodes are entered
            do
            {
                //Compare the entered value with the current node we are on so that we know where to add it
                //If it's smaller we add it to the left side of the tree
                if (value <= currNode.BossName)
                {
                    //If the child of the node is null we create a new node and add it to the tree
                    if (currNode.Left == null)
                    {
                        //Create a new node with the value
                        Node newNode = new Node(value);
                        //Assign the newly created node to the left child of the tree
                        currNode.Left = newNode;
                        //Mark that it is added successfully
                        added = true;
                    }
                    //If the node is not null move the pointer to the child
                    else
                    {
                        currNode = currNode.Left;
                    }
                }
                //Compare the entered value with the current node we are on so that we know where to add it
                //If it's greater we add it to the right side of the tree
                if (value >= currNode.BossName)
                {
                    //If the child of the node is null we create a new node and add it to the tree
                    if (currNode.Right == null)
                    {
                        //Create a new node with the value
                        Node newNode = new Node(value);
                        //Assign the newly created node to the left child of the tree
                        currNode.Right = newNode;
                        //Mark that it is added successfully
                        added = true;
                    }
                    //If the node is not null move the pointer to the child
                    else
                    {
                        currNode = currNode.Right;
                    }
                }
            }
            while (!added);
        }
    }

}