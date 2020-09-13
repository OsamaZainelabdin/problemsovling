using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
   public class DiameterBinaryTree
    {
        public TreeNode treeNode1;
        int ans;
        public DiameterBinaryTree()
        {
            treeNode1 = new TreeNode();           

            treeNode1.val = 100;

            treeNode1.left = new TreeNode(2);
            treeNode1.right = new TreeNode(3);

            treeNode1.left.left = new TreeNode(4);
            treeNode1.left.right = new TreeNode(5);

            treeNode1.right.left = new TreeNode(6);
            treeNode1.right.right = new TreeNode(7);
            treeNode1.right.right.right = new TreeNode(8);
            treeNode1.right.right.right.right = new TreeNode(9);
        }


        public int DiameterOfBinaryTree(TreeNode node)
        {
            int depth = 0;

            if (node == null)
            {
                return 0;
            }
            else
            {
                depth = DepthMax(node);
            }

            return depth;

        }

        public int DepthMax(TreeNode node)
        {
            if (node == null)
                return 0;
            else
            {
                /* compute the depth of each subtree */
                int lDepth = DepthMax(node.left);
                int rDepth = DepthMax(node.right);

                // use the larger one 
                if (lDepth > rDepth)
                    return (lDepth + 1);
                else
                    return (rDepth + 1);
            }
        }

    }
}
