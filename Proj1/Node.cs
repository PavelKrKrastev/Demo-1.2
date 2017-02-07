using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj1
{
    class Node
    {

        private string bossName;

        public string BossName
        {
            get { return bossName; }
            set { bossName = value; }
        }

        private Node left;

        public Node Left
        {
            get { return left; }
            set { left = value; }
        }

        private Node right;

        public Node Right
        {
            get { return right; }
            set { right = value; }
        }

        public Node(string item)
        {
            bossName = item;
            left = right = null;
        }
    }
}
