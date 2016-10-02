public class NumMatrix {
    int [,] arr;
    int [,] rowSums;
    public NumMatrix(int[,] matrix) {
        arr = matrix;
        rowSums = new int[arr.GetLength(0), arr.GetLength(1)];
        int sum = 0;
        for(int i=0; i< arr.GetLength(0);i++)
        {   
            sum = 0;
            for(int j=0; j<arr.GetLength(1); j++)
            {   
                sum += arr[i,j];
                rowSums[i, j] = sum;
            }
        }
    }

    public void Update(int row, int col, int val) {
        for(int j=col;j<arr.GetLength(1); j++)
            rowSums[row, j] = rowSums[row, j] - arr[row,col] + val;
        arr[row, col] = val;
    }

    public int SumRegion(int row1, int col1, int row2, int col2) {
        int sum=0;
        for(int i=row1; i<=row2; i++)    
            {   //Console.WriteLine(sum);
                sum += rowSums[i, col2];
                for(int j=0; j<col1; j++)
                    sum -= arr[i, j];
            }
        // Console.WriteLine();
         return sum;
    }
}


// Your NumMatrix object will be instantiated and called as such:
// NumMatrix numMatrix = new NumMatrix(matrix);
// numMatrix.SumRegion(0, 1, 2, 3);
// numMatrix.Update(1, 1, 10);
// numMatrix.SumRegion(1, 2, 3, 4);
