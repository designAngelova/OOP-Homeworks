using System;

namespace CustomBinaryTree
{
    public class Tester
    {
        public static void Main()
        {
            Node treeNode = new Node();
            BinarySearchTree.Insert(ref treeNode, 10);
            BinarySearchTree.Insert(ref treeNode, 3);
            BinarySearchTree.Insert(ref treeNode, 9);

            BinarySearchTree.Remove(ref treeNode, 3);

            // Nothing is printed out  - node is removed
            Console.WriteLine(BinarySearchTree.Search(ref treeNode, 3));
        }
    }
}
