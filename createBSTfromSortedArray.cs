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
	
	public void Print()
	{
		if(left!=null)
			left.Print();
		Console.Write(value + " ");
	
		if(right!= null)
			right.Print();
	}
}
	
public class Program
{
	public static void Main()
	{
		int [] arr = {2, 3, 5, 7, 9};
	
		Node root = InsertIntoBST(arr, 0, arr.Length - 1, 0);
		root.Print();
	}

    public static Node InsertIntoBST(int [] arr, int left, int right, int count)
	{
		if(left > right) return null;
		
		//if(count > arr.Length) return null;
		
		int mid = (left + right)/2;
		
		Node root = new Node(arr[mid]);
		count++;
	//	Console.WriteLine(count);
		root.left = InsertIntoBST(arr, left, mid-1, count);
		root.right = InsertIntoBST(arr, mid+1, right, count);
		
		return root;
	}
}
