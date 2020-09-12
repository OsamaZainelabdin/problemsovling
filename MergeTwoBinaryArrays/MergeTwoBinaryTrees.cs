using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{

    //Definition for a binary tree node.
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
        public TreeNode() { }
        public TreeNode(int val) {
            this.val = val;
        }
    }

    public class MergeTwoBinaryTrees
    {
        public TreeNode treeNode1;
        public TreeNode treeNode2;        
        public MergeTwoBinaryTrees() {

            treeNode1 = new TreeNode();
            treeNode2 = new TreeNode();

            treeNode1.val = 100;          

            treeNode1.left = new TreeNode(2);
            treeNode1.right = new TreeNode(3);

            treeNode1.left.left = new TreeNode(4);
            treeNode1.left.right = new TreeNode(5);

            treeNode1.right.left = new TreeNode(6);
            treeNode1.right.right = new TreeNode(7);

            ////
            treeNode2.val = 200;

            treeNode2.left = new TreeNode(20);
            treeNode2.right = new TreeNode(30);

            treeNode2.left.left = new TreeNode(40);
            treeNode2.left.right = new TreeNode(50);

            treeNode2.right.left = new TreeNode(60);
            treeNode2.right.right = new TreeNode(70);
                       
        }
        public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            if (t1 == null)
                return t2;
            if (t2 == null)
                return t1;
            t1.val = t1.val + t2.val;
            t1.left = MergeTrees(t1.left, t2.left);
            t1.right = MergeTrees(t1.right, t2.right);

            return t1;
        }

        public void print(TreeNode tree)
        {
            if (tree != null)
                Console.WriteLine(tree.val);
            if (tree.left != null)
                print(tree.left);
            if (tree.right != null)
                print(tree.right);
        }
    }
}
