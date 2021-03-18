using System;

namespace BinaryTreeSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();

            for (int i = 1; i < 9; i++)
            {
                if (i == 7)
                {
                    binaryTree.Remove(7);
                    binaryTree.Add(8);
                }

                if (i == 8)
                {
                    binaryTree.Add(7);
                }
                binaryTree.Add(i);
            }

            Node node = binaryTree.Find(1);
            int depth = binaryTree.GetTreeDepth();
            
            Console.WriteLine("Preorder Traversal: ");
            binaryTree.TraversePreOrder(binaryTree.Root);
            Console.WriteLine();
            
            Console.WriteLine("InOrder Traversal: ");
            binaryTree.TraverseInOrder(binaryTree.Root);
            Console.WriteLine();

            Console.WriteLine("PostOrder Traversal: ");
            binaryTree.TraversePostOrder(binaryTree.Root);
            Console.WriteLine();
            
            binaryTree.Remove(7);
            binaryTree.Remove(8);
            
            Console.WriteLine("PreOrder Traversal After Removing Operation:");
            binaryTree.TraversePreOrder(binaryTree.Root);
            Console.WriteLine();
 
            Console.ReadLine();

        }
    }
}
