using System;

public class TreeNode 
{
    public int Data;
    public TreeNode left;
    public TreeNode right;
    public TreeNode parent;
    public TreeNode(int value)
    {
        Data = value;
    }
    public void SetLeftChild(TreeNode left)
    {
        this.left = left;
        if (left!=null)
        {
            left.parent = this;
        }
    }
    public void SetRightChild(TreeNode right) 
    {
        this.right = right;
        if (right!=null)
        {
            right.parent = this;
        }
    }
    public void Insert(int number)
    {
        if (number < Data)
        {
            if (left==null)
            {
                SetLeftChild(new TreeNode(number));
            } else
            {
                left.Insert(number);
            }
        } else
        {
            if (right == null)
            {
                SetRightChild(new TreeNode(number));
            }else
            {
                right.Insert(number);
            }
        }
    }
    public bool IsBST()
    {
        if(left!=null)
        {
            if (left.Data>Data || !left.IsBST())
            {
                return false;
            }
        }
        if (right!=null)
        {
            if (right.Data<Data || !right.IsBST())
            {
                return false;
            }
        }
        return true;
    }
    public int Height 
    {
        get 
        {
            int leftHeight = left!=null?left.Height:0;
            int rightHeight = right!=null?right.Height:0;
            return 1 + Math.Max(leftHeight,rightHeight);
        }
    }
    public TreeNode Find(int number) 
    {
        
        if (Data==number) return this;
        if (Data<number) 
        {
            return (left!=null?left.Find(number):null);        
        } else
        {
            return (right!=null?right.Find(number):null);
        }
        return null;
    }
    public static TreeNode AddToTree(int[] arr, int start, int end)
    {
        if (end<start) 
        {
            return null;
        }
        int mid = (end+start)/2;
        TreeNode n = new TreeNode(arr[mid]);
        n.SetLeftChild(AddToTree(arr,start, mid-1));
        n.SetRightChild(AddToTree(arr,mid+1, end));
        return n;
    }
    public static TreeNode CreateBST(int[] arr)
    {
        return AddToTree(arr,0, arr.Length-1);
    }
    
}