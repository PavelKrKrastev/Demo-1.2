using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enter the root of the tree
            Console.Write("Please enter the root of the tree: ");
            int k = 0;
            //Verify that the input is an integer
            while (!int.TryParse(Console.ReadLine(), out k))
            {
                Console.Write("Please enter a valid numerical value!" );
            }
            //Create an isnatnce of the Binarytree class passing the name of the root element
            BinaryTree tree = new BinaryTree(k);

            //Enter the number of nodes in the tree
            Console.Write("\nEnter how many nodes you want to add to the tree: ");

            String Result = Console.ReadLine();

            int n;

            //Check that the input is a number
            while (!Int32.TryParse(Result, out n))
            {
                //if it's not a number prompt user to enter again until it's a number
                Console.Write("Please enter a number! ");

                Result = Console.ReadLine();
            }

            Console.Write("\n");

            //Loop for creating the tree with the specified number of nodes
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Please enter nodes of the tree: ");
                int s = 0;
                //Verify that the input is an integer
                while (!int.TryParse(Console.ReadLine(), out s))
                {
                    Console.WriteLine("Please enter a valid numerical value!");
                }
                //Employees can't have the same name as the CEO
                if (s.Equals(k))
                {
                    Console.Write("Enter a different name!");
                    s = Convert.ToInt32(Console.ReadLine());
                }
                //Add the node into the tree
                tree.AddNode(s);
            }
            Console.WriteLine("\nPress Enter to input nodes for LCA!");

            while (!(Console.ReadKey(true).Key == ConsoleKey.Escape))
            {
                //Enter nodes to check if they have a common antcestor 
                Console.Write("\nEnter a node: ");
                int h = 0;
                //Verify that the input is an integer
                while (!int.TryParse(Console.ReadLine(), out h))
                {
                    Console.WriteLine("Please enter a valid numerical value!");
                }

                Console.Write("Enter a second node: ");
                int j = 0;
                //Verify that the input is an integer
                while (!int.TryParse(Console.ReadLine(), out j))
                {
                    Console.WriteLine("Please enter a valid numerical value!");
                }

                //Pass the names to the function to see if they have a common boss
                Node lca = tree.EnterBoss(h, j);
                //if they do we return the name
                if (lca != null)
                {
                    Console.WriteLine("\nThe lowest common antcestor is: " + lca.BossName);
                    Console.WriteLine("\n(Esc to exit / Any key to continue!)");
                }
                //Else we return a message to indicate that one of the people isn't in the tree
                else
                {
                    Console.WriteLine("\nBoth of the nodes are missing from the tree!");
                    Console.WriteLine("\n(Esc to exit / Any key to continue!)");
                }
            }
        }
    }
}
