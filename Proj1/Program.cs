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
            Console.Write("Enter CEO: ");
            string k = Console.ReadLine();
            BinaryTree tree = new BinaryTree(k);

            Console.Write("Enter how many people u want to add to the tree: ");

            String Result = Console.ReadLine();

            int n;

            while (!Int32.TryParse(Result, out n))
            {
                Console.Write("Please enter a number! ");

                Result = Console.ReadLine();
            }


            for (int i = 1; i <= n; i++)
            {
                Console.Write("Enter employee: ");
                string s = Console.ReadLine();
                if (s.Equals(k))
                {
                    Console.WriteLine("Enter a different name!");
                    s = Console.ReadLine();
                }
                tree.AddNode(s);
            }

            Console.Write("Enter a boss: ");
            string h = Console.ReadLine();

            Console.Write("Enter another boss: ");
            string j = Console.ReadLine();

            Node lca = tree.EnterBoss(h, j);
            /*if (lca != null)
            {*/
                Console.WriteLine(lca.BossName);
            /*}
            else
            {
                Console.WriteLine("One of the pople entered doesn't work in this company");
            }*/
        }
    }
}
