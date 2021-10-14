using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_Down_node
{
    
    public class TreeNode
    {
        public int data;
        public TreeNode left, right;
        public TreeNode(int data)
        {
            this.data = data;
            left = right = null;
        }
    }
}
