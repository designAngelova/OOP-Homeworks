namespace CustomBinaryTree
{
    public class Node
    {
        public int value;
        public Node left;
        public Node right;

        public void SetLeftNode(ref Node leftNode)
        {
            this.left = leftNode;
        }

        public void SetRightNode(ref Node rightNode)
        {
            this.right = rightNode;
        }

        public override string ToString()
        {
            return string.Format("Value: {0}", value);
        }
    }
}
