using System;

namespace Left_Down_node
{
    class Program
    {
        private static int L = 0;
        private static int res = 0;
        static void Main(string[] args)
        {
            TreeNode tree = new TreeNode(1);
            tree.left = new TreeNode(2);
            tree.right = new TreeNode(3);
            tree.left.left = new TreeNode(4);
            tree.right.left = new TreeNode(5);
            tree.right.left.left = new TreeNode(7);
            tree.right.right = new TreeNode(6);
            Console.WriteLine(FindBottomLeftValue(tree));
        }

        public static int FindBottomLeftValue(TreeNode root)
        {
            FindBottomLeftValueUtil(root, 1);
            return res;
        }

        public static void FindBottomLeftValueUtil(TreeNode root,int Curr)
        {
            //if (root == null)
            //    return ;
            if ( Curr>L)
            {
                L=Curr ;
                res = root.data;
            }

            if (root.left != null)
                FindBottomLeftValueUtil(root.left, Curr + 1);
            //L--;
            if (root.right != null)
                FindBottomLeftValueUtil(root.right, Curr + 1);


        }
    }
}
