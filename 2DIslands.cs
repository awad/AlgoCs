public class Solution {
    public int NumIslands(char[,] grid) {
        int islands = 0;
        
       // PrintGrid(grid);
      //  Console.WriteLine("Rank {0}", grid.Rank);
        for(int i=0; i< grid.GetLength(0); i++)
        {
            for(int j=0;j<grid.GetLength(1); j++)
            {
               // Console.WriteLine("Processing {0},{1}", i, j);
                if(grid[i,j] == '1')
                {
                    //if(!isConnectedToExistingIsland(grid, i, j)){
                        islands++;
                        Console.WriteLine("New Island {0}, {1}", i, j);
                    //}
                     grid[i, j] = '2';
                     SetConnectedCells(grid, i, j);
                     if(j+1<grid.GetLength(1) && grid[i, j+1] == '1') grid[i, j+1] = '2';
                     if(i+1<grid.GetLength(0) && grid[i+1, j] == '1') grid[i+1, j] = '2';
                }
            }
        }
      //  PrintGrid(grid);
        return islands;
    }
    
    public void SetConnectedCells(char[,] grid, int i, int j)
    {
        if(i>0 && grid[i-1,j] == '1')
        {
           grid[i-1, j] = '2';
           SetConnectedCells(grid, i-1, j);
        }
        if(j>0 && grid[i,j-1] == '1')
        {
            grid[i,j-1] = '2';
            SetConnectedCells(grid, i, j-1);
        }
        if(j+1<grid.GetLength(1) && grid[i, j+1] == '1') 
        {
            grid[i, j+1] = '2';
            SetConnectedCells(grid, i, j+1);
        }
        if(i+1<grid.GetLength(0) && grid[i+1, j] == '1') 
        {
            grid[i+1, j] = '2';
            SetConnectedCells(grid, i+1, j);
        }
    }
    public void PrintGrid(char [,] grid)
    {
         for(int i=0; i< grid.GetLength(0); i++)
        {
            for(int j=0;j<grid.GetLength(1); j++)
            {
                Console.Write(grid[i, j]);
            }
            Console.WriteLine();
        }
    }
    public bool isConnectedToExistingIsland(char [,] grid, int i, int j)
    {
        if(i>0 && grid[i-1,j] == '2')
        {
            return true;
        }
        if(j>0 && grid[i,j-1] == '2')
        {
            return true;
        }
        if(j+1<grid.GetLength(1) && grid[i, j+1] == '2') return true;
        if(i+1<grid.GetLength(0) && grid[i+1, j] == '2') return true;
        
        return false;
    }
}
