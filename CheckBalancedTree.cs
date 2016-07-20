using System;
					
public class Node
{
	int value;
	public Node left, right;
	
	public Node(int n)
	{
		value = n;
		left = null;
		right = null;
	}
	
	public Node() { value = 0; }
	
	public void InOrderPrint()
	{
		if(left!=null)
			left.InOrderPrint();
		
		Console.Write(value + " ");
	
		if(right!= null)
			right.InOrderPrint();
	}
	
}
public class Program
{
	public static bool isBalanced(Node root)
	{
		if(root == null)
			return true;
		
		if(checkHeight(root) == -1)
			return false;
		else 
			return true;
			
	}
	
	public static int checkHeight(Node node)
	{
		if (node == null)
			return 0;
		int left = checkHeight(node.left);
		int right = checkHeight(node.right);
		if(left == -1 || right == -1)
			return -1;
			
		if(Math.Abs(left - right) > 1)
			return -1;
		else return Math.Max(left, right) + 1;
		
	}
	
	public static void Main(String [] args)
	{
		Node root = new Node(20);
		root.left = new Node(10);
		root.right = new Node(30);
		root.left.left = new Node(5);
		root.left.right = new Node(15);
		root.right.right = new Node(35); // commenting makes a unbalanced tree
		root.left.left.left = new Node(2);
		
		Console.WriteLine(isBalanced(root));
	}
}
