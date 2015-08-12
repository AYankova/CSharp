using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeImplementation
{
    class Program
    {
        static void Main()
        {
            var sb = new StringBuilder();

            var tree = new BinarySearchTree<int>(15);

            for (int i = 0; i < 30; i++)
            {
                tree.Add(i);
            }

            var clonedNode = (TreeNode<int>)tree.Root.Clone();

            sb.AppendLine(tree.ToString())
                .AppendLine("Tree root: " + tree.Root.ToString())
                .AppendLine("Tree contains 7? " + tree.Contains(7).ToString())
                .AppendLine("Cloned root: " + clonedNode.ToString())
                .AppendLine("Cloned Equals root? " + (clonedNode.Equals(tree.Root)).ToString())
                .AppendLine("Cloned == root? " + (clonedNode == tree.Root).ToString())
                .AppendLine("Cloned != root? " + (clonedNode != tree.Root).ToString())
                .AppendLine("12 deleted. New tree:");

            Console.Write(sb.ToString());

            tree.Delete(12);
            Console.WriteLine(tree.ToString());
     
        }
    }
}
