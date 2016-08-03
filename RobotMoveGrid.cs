using System;
					
public class Program
{
	static int m = 3;
	static int n = 3;
	static bool [,] obstacles = new bool[m+1, n+1];
	static bool [,] cacheObstacles = new bool[m+1, n+1];
	public static void Main()
	{
		
		String path = "";
		obstacles[1,3] = true;
		obstacles[2,2] = true;
		int count = 0;
		isPath(0, 0, m, n, ref count, ref path);
		Console.WriteLine("-----Path is: {0}, Count {1}", path, count);
		
		path ="";
		count = 0;
		isPathDP(0, 0, m, n, ref count, ref path);
		Console.WriteLine("-----Path is: {0}, Count {1}", path, count);
		
	}
	
	public static bool isPath(int r, int c, int m, int n, ref int count, ref String path)
	{
		if(r==m && c == n)
			return true;
		
		count++;
		if(isValid(r, c, r, c+1))
		{
			path += 'R';
			Console.WriteLine("Adding "+ (r) + "," + (c+1) +" Path is: " + path);
		
			if(isPath(r, c+1, m, n, ref count, ref path))
				return true;
			path = path.Remove(path.Length - 1);		
		}
		
		count++;
		if(isValid(r, c, r+1, c))
		{
			path += 'D';
			Console.WriteLine("Adding "+ (r+1) + "," + c +" Path is: " + path);
			if(isPath(r+1, c, m, n, ref count, ref path))
				return true;
			else
				path = path.Remove(path.Length - 1);
		}

		return false;
	}
	
	public static bool isPathDP(int r, int c, int m, int n, ref int count, ref String path)
	{
		if(r==m && c == n)
			return true;
		
		count++;
		//Console.WriteLine("Path: {0} trying right", path);
		if(isValid(r, c, r, c+1))
		{
			path += 'R';
			Console.WriteLine("Adding "+ (r) + "," + (c+1) +" Path is: " + path);
		
			if(isPathDP(r, c+1, m, n, ref count, ref path))
				return true;
			path = path.Remove(path.Length - 1);		
		}
		
		count++;
		//Console.WriteLine("Path: {0} trying down", path);
		if(isValid(r, c, r+1, c))
		{
			path += 'D';
			Console.WriteLine("Adding "+ (r+1) + "," + c +" Path is: " + path);
			if(isPathDP(r+1, c, m, n, ref count, ref path))
				return true;
			else
				path = path.Remove(path.Length - 1);
		}
		
		Console.WriteLine("Add Cache at {0},{1}", r, c);
		cacheObstacles[r, c] = true;
		return false;
	}
	
	public static bool isValid(int r, int c, int r1, int c1)
	{

		if(r1 <= m && c1 <= n)
		{
			if(cacheObstacles[r1,c1])
				return false;
			if(!obstacles[r1,c1])
				return true;
		}
		
		if(r1<=m && c1<=n && obstacles[r1,c1])
			Console.WriteLine("Hit obstacle at {0},{1}", r1, c1);
		
		return false;
	}
}
