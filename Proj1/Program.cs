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
            BinaryTree tree = new BinaryTree();

            //Enter the number of nodes in the tree
            Console.Write("Enter how many nodes you want to add to the tree: ");

            int num;

            //Check that the input is a number
            while (!Int32.TryParse(Console.ReadLine(), out num))
            {
                //if it's not a number prompt user to enter again until it's a number
                Console.Write("Please enter a number! ");
            }

            Console.Write("\n");

            //Loop for creating the tree with the specified number of nodes
            for (int i = 1; i < num; i++)
            {
                if(tree.Top == null)
                {
                    Console.Write("Please enter the root of the tree: ");
                    int root = 0;
                    //Verify that the input is an integer
                    while (!int.TryParse(Console.ReadLine(), out root))
                    {
                        Console.Write("Please enter a valid numerical value!");
                    }
                    tree.Top = new Node(root);
                }

                if (num == 1)
                {
                    break;
                }

                else
                {
                    Console.Write("Please enter nodes of the tree: ");
                    int enterNode = 0;
                    //Verify that the input is an integer
                    while (!int.TryParse(Console.ReadLine(), out enterNode))
                    {
                        Console.WriteLine("Please enter a valid numerical value!");
                    }
                    //Employees can't have the same name as the CEO
                    if (enterNode.Equals(num))
                    {
                        Console.Write("Enter a different name!");
                        enterNode = Convert.ToInt32(Console.ReadLine());
                    }
                    //Add the node into the tree
                    tree.AddNode(enterNode);
                }
            }
            Console.WriteLine("\nPress Enter to input nodes for LCA!");

            while (!(Console.ReadKey(true).Key == ConsoleKey.Escape))
            {
                //Enter nodes to check if they have a common antcestor 
                Console.Write("\nEnter a node: ");
                int firstNode = 0;
                //Verify that the input is an integer
                while (!int.TryParse(Console.ReadLine(), out firstNode))
                {
                    Console.WriteLine("Please enter a valid numerical value!");
                }

                Console.Write("Enter a second node: ");
                int secondNode = 0;
                //Verify that the input is an integer
                while (!int.TryParse(Console.ReadLine(), out secondNode))
                {
                    Console.WriteLine("Please enter a valid numerical value!");
                }

                //Pass the names to the function to see if they have a common boss
                Node lca = tree.EnterBoss(firstNode, secondNode);

                try
                {
                    Console.WriteLine("\nThe lowest common antcestor is: " + lca.BossName);
                    Console.WriteLine("\n(Esc to exit / Any key to continue!)");
                }
                catch(System.NullReferenceException)
                {
                    Console.WriteLine("\nNo nodes found! ");
                    Console.WriteLine("\n(Esc to exit / Any key to continue!)");
                }
            }
        }
    }
}
