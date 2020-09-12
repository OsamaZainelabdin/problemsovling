using System;

namespace ProblemSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MergeTwoBinaryTrees m = new MergeTwoBinaryTrees();
            m.print(m.treeNode1);
            Console.WriteLine("-----------------");
            m.print(m.treeNode2);
            TreeNode res = m.MergeTrees(m.treeNode1, m.treeNode2);
            Console.WriteLine("-----------------");
            m.print(res);
            Console.ReadLine();
        }
    }
}
