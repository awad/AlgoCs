using System;
public class Solution {
	
	public static void Main()
	{
		string[] board = new string[] {"..9748...","7........",".2.1.9...","..7...24.",".64.1.59.",".98...3..","...8.3.2.","........6","...2759.."};
		
		char [,] cBoard = new char [9,9];
		for(int i=0;i<9; i++)
			{
				for(int j=0;j<9; j++)
				{
			  		cBoard[i,j] = board[i][j]; 
				}
			}
			
		SolveSudoku(cBoard);
		for(int i=0; i<9; i++)
		{
			for(int j=0; j<9; j++)
				Console.Write(cBoard[i,j]);
			Console.WriteLine();
		}
		

	}
		
    public static void SolveSudoku(char [,] board)
    {
        sudokuSolver(board, 0, 0);
    }
	
	public static bool sudokuSolver(char [,] board, int r, int c)
	{
		if(r == 9) return true;
		if(c==9) return sudokuSolver(board, r+1, 0);
		if(board[r,c] != '.') return sudokuSolver(board, r, c+1);
		for(char i='1'; i<='9'; i++)
		{
			if(isValid(board, r, c, i))
			{
				board[r,c] = i;
				
				if(sudokuSolver(board, r, c+1))
					return true;
				
				board[r,c] ='.';
				
			}
		}
		return false;	
	}
	
	public static bool isValid(char [,] board, int r, int  c, int n)
	{
		for(int i=0; i<9;i++)
		{
			if(n == board[r,i]) return false;
			
			if(n == board[i, c]) return false;
			
		}
		
		int row = r- r%3; int col = c-c%3;
		
	
		for(int i=row; i<row+3; i++)
		{
			for(int j=col; j<col+3; j++)
			{
				if(n == board[i,j]) return false;
			}
		}
		return true;
	}
}
