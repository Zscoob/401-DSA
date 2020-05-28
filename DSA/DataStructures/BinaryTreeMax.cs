using System;

public class Node
{
    public int data;
    public Node left, right;

    public Node(int data)
    {
        this.data = data;
        left = right = null;
    }
}

public class BinaryTreeMax
{
    public Node root;


    public static int findMax(Node node)
    {
        if (node == null)
        {
            return int.MinValue;
        }

        int res = node.data;
        int lefty = findMax(node.left);
        int righty = findMax(node.right);

        if (lefty > res)
        {
            res = lefty;
        }
        if (righty > res)
        {
            res = righty;
        }
        return res;
    }
};
  