namespace RotateMatrixAPI.Services
{
    public interface IMatrixService
    {
        int[][] RotateMatrixCounterClockwise(int[][] matrix);

    }

    public class MatrixService : IMatrixService
    {
        public int[][] RotateMatrixCounterClockwise(int[][] matrix)
        {

            int n = matrix.Length;
            int[][] rotatedMatrix = new int[n][];

            for (int i = 0; i < n; i++)
            {
                rotatedMatrix[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    rotatedMatrix[i][j] = matrix[j][n - 1 - i];
                }
            }

            return rotatedMatrix;
        }
    }
}
