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
            Console.Write("Enter CEO: ");
            int k = Convert.ToInt32(Console.ReadLine());
            //Create an isnatnce of the Binarytree class passing the name of the root element
            BinaryTree tree = new BinaryTree(k);

            //Enter the number of nodes in the tree
            Console.Write("Enter how many people u want to add to the tree: ");

            String Result = Console.ReadLine();

            int n;

            //Check that the input is a number
            while (!Int32.TryParse(Result, out n))
            {
                //if it's not a number prompt user to enter again until it's a number
                Console.Write("Please enter a number! ");

                Result = Console.ReadLine();
            }

            //Loop for creating the tree with the specified number of nodes
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Enter employee: ");
                int s = Convert.ToInt32(Console.ReadLine());
                //Employees can't have the same name as the CEO
                if (s.Equals(k))
                {
                    Console.WriteLine("Enter a different name!");
                    s = Convert.ToInt32(Console.ReadLine());
                }
                //Add the node into the tree
                tree.AddNode(s);
            }

            //Enter nodes to check if they have a common antcestor 
            Console.Write("Enter a boss: ");
            int h = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another boss: ");
            int j = Convert.ToInt32(Console.ReadLine());

            //Pass the names to the function to see if they have a common boss
            Node lca = tree.EnterBoss(h, j);
            //if they do we return the name
            if (lca != null)
            {
                Console.WriteLine(lca.BossName);
            }
            //Else we return a message to indicate that one of the people isn't in the tree
            else
            {
                Console.WriteLine("One of the pople entered doesn't work in this company");
            }
        }
    }
}
