namespace CustomBinaryTree
{
    public class BinarySearchTree
    {
        public static Node Insert(ref Node treeNode, int key)
        {
            if (treeNode == null)
            {
                Node newNode = new Node();
                newNode.left = null;
                newNode.right = null;
                newNode.value = key;
                return newNode;
            }

            if (key < treeNode.value)
            {
                treeNode.left = Insert(ref treeNode.left, key);
            }
            else
            {
                treeNode.right = Insert(ref treeNode.right, key);
            }

            return treeNode;
        }

        public static Node Search(ref Node treeNode, int key)
        {
            if (treeNode == null)
            {
                return null;
            }
            else if (key == treeNode.value)
            {
                return treeNode;
            }
            else if (key < treeNode.value)
            {
                return Search(ref treeNode.left, key);
            }
            else
            {
                return Search(ref treeNode.right, key);
            }
        }

        public static Node Remove(ref Node treeNode, int key)
        {
            if (treeNode == null)
            {
                return null;
            }

            if (treeNode.value == key)
            {
                if (treeNode.left == null)
                {
                    Node rightSubtree = treeNode.right;
                    treeNode = null;
                    return rightSubtree;
                }

                if (treeNode.right == null)
                {
                    Node leftSubtree = treeNode.left;
                    treeNode = null;
                    return leftSubtree;
                }

                Node maxNode = FindMaxNode(ref treeNode.left);
                maxNode.left = treeNode.left;
                maxNode.right = treeNode.right;
                treeNode = null;
                return maxNode;
            }
            else if (key < treeNode.value)
            {
                treeNode.left = Remove(ref treeNode.left, key);
            }
            else
            {
                treeNode.right = Remove(ref treeNode.right, key);
            }

            return treeNode;
        }

        public static Node FindMaxNode(ref Node treeNode)
        {
            if (treeNode == null)
            {
                return null;
            }

            if (treeNode.right == null)
            {
                return treeNode;
            }

            return FindMaxNode(ref treeNode.right);
        }
    }
}
