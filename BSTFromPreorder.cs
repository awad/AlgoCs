using System;
using System.Collections.Generic;
					
public class Program
{
	public class Node
	{
		public Node left;
		public Node right;
		public int data;
		
		public Node(int data)
		{
			this.data= data;
			left = null;
			right = null;
		}
	}
	
	public static void Main()
	{
		int [] pre = new int [] {5, 3, 1, 4, 10, 7, 11};
		Node root1= constructTree(pre);
		LevelWisePrint(root1);
		
		
		Node root = new Node(20);
		root.left = new Node(10);
		root.right = new Node(30);
		root.left.left = new Node(5);
		root.left.right = new Node(15);
		root.right.right = new Node(35);
		root.left.left.left = new Node(2);
		
		LevelWisePrint(root);
	}
	
	public static Node constructTree(int [] pre)
	{
		int index =0;
		Node root = constructTree(pre, ref index, int.MinValue, int.MaxValue); 
		return root;
	}
	
	public static Node constructTree(int [] pre, ref int index, int min, int max)
	{
		if(index >= pre.Length)
			return null; 
		
		if(pre[index] >= min && pre[index] <= max)
			{
				Node root =  new Node(pre[index]);
				index++;
				root.left =  constructTree(pre, ref index, min, root.data);
				root.right = constructTree(pre, ref index, root.data, max);
				return root;
			}
			else 
				return null;
	}
	
	public static void LevelWisePrint(Node root)
	{
		Queue<Node> parent = new Queue<Node>();
		Queue<Node> current = new Queue<Node>();
		
		current.Enqueue(root);
		Node n = null;
		while(current.Count > 0)
		{
			parent = current;
			current = new Queue<Node>();
//Console.WriteLine("PC: " + parent.Count);
			while(parent.Count > 0)
			{	
				n = parent.Dequeue();
				Console.Write(n.data + "\t");
				if(n.left != null)
					current.Enqueue(n.left);
				if(n.right != null)
					current.Enqueue(n.right);
			}
			Console.WriteLine();
			
		}
		
	}	
	
}
