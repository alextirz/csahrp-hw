namespace OperatorOverloading
{
    internal class Matrix
    {
        private double[,] data;

        public int Rows { get; }
        public int Columns { get; }

        public double this[int row, int col]
        {
            get
            {
                if (row < 0 || row >= Rows || col < 0 || col >= Columns)
                    throw new IndexOutOfRangeException("Indexer you are trying to access is outside of the dimensions of the matrix.");
                return data[row, col];
            }
            set
            {
                if (row < 0 || row >= Rows || col < 0 || col >= Columns)
                    throw new IndexOutOfRangeException("Indexer you are trying to set is outside of the dimensions of the matrix.");
                data[row, col] = value;
            }
        }

        public Matrix(int rows, int columns)
        {
            if (rows <= 0 || columns <= 0)
                throw new ArgumentException("Matrix dimensions must be positive.");
            Rows = rows;
            Columns = columns;
            data = new double[rows, columns];
        }

        public Matrix(double[,] initialData)
        {
            Rows = initialData.GetLength(0);
            Columns = initialData.GetLength(1);
            data = (double[,])initialData.Clone();
        }

        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            if (m1.Rows != m2.Rows || m1.Columns != m2.Columns)
                throw new InvalidOperationException("Matrices must have the same dimensions.");

            var result = new Matrix(m1.Rows, m1.Columns);
            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m1.Columns; j++)
                {
                    result[i, j] = m1[i, j] + m2[i, j];
                }
            }
                
            return result;
        }

        public static Matrix operator -(Matrix m1, Matrix m2)
        {
            if (m1.Rows != m2.Rows || m1.Columns != m2.Columns)
                throw new InvalidOperationException("Matrices must have the same dimensions.");

            var result = new Matrix(m1.Rows, m1.Columns);
            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m1.Columns; j++)
                {
                    result[i, j] = m1[i, j] - m2[i, j];
                }

            }
              
            return result;
        }

        public static Matrix operator *(Matrix m1, Matrix m2)
        {
            if (m1.Columns != m2.Rows)
                throw new InvalidOperationException("Number of columns of first matrix must be equal to the number of rows in the second matrix.");

            var result = new Matrix(m1.Rows, m2.Columns);

            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m2.Columns; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < m1.Columns; k++)
                    {
                        //i is the current row of the matrix1; 
                        //j is the current column of the matrix 2;
                        //k is the column of the martix1 we need to iterate, which is the same as the row of the martix2;
                        result[i, j] += m1[i, k] * m2[k, j]; 
                    }
                }
            }

            return result;
        }

        public static bool operator ==(Matrix m1, Matrix m2)
        {
            if (m1.Rows != m2.Rows || m1.Columns != m2.Columns)
            {
                return false;
            }
            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m1.Columns; j++)
                {
                    if (m1[i, j] != m2[i, j]) 
                        return false;
                }
            }
               
            return true;
        }

        public static bool operator !=(Matrix m1, Matrix m2) => !(m1 == m2);
    }
}