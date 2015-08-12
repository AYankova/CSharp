namespace Matrix
{
    using System;
    using System.Text;

    public class Matrix<T> where T : struct,IComparable
    {
        private T[,] matrix;

        public Matrix(int rows, int cols)
        {
            this.matrix = new T[rows, cols];
        }

        public Matrix(T[,] sampleMatrix)
        {
            this.matrix = sampleMatrix;
        }

        public int RowsCount
        {
            get { return this.matrix.GetLength(0); }
        }

        public int ColumnsCount
        {
            get { return this.matrix.GetLength(1); }
        }

        public T[,] GetMatrix
        {
            get { return this.matrix; }
        }

        public T this[int row, int col]
        {
            get
            {
                if (row < 0 || row >= this.RowsCount)
                {
                    throw new IndexOutOfRangeException("Invalid argument rows!");
                }

                if (col < 0 || col >= this.ColumnsCount)
                {
                    throw new IndexOutOfRangeException("Invalid argument columns!");
                }

                return this.matrix[row, col];
            }

            set
            {
                if (row < 0 || row >= this.RowsCount)
                {
                    throw new IndexOutOfRangeException("Invalid argument rows!");
                }

                if (col < 0 || col >= this.ColumnsCount)
                {
                    throw new IndexOutOfRangeException("Invalid argument columns!");
                }

                this.matrix[row, col] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix == null || secondMatrix == null)
            {
                throw new NullReferenceException();
            }

            if (firstMatrix.RowsCount!=secondMatrix.RowsCount || firstMatrix.ColumnsCount!=secondMatrix.ColumnsCount)
            {
                throw new ArgumentException("Operator add cannot be applied to matrices with different length!");
            }

            Matrix<T> result = new Matrix<T>(firstMatrix.RowsCount, secondMatrix.ColumnsCount);

            for (int i = 0; i < result.RowsCount; i++)
            {
                for (int j = 0; j < result.ColumnsCount; j++)
                {
                    result[i, j] = (dynamic)firstMatrix[i, j] + (dynamic)secondMatrix[i, j];
                }
            }

            return result;
        }

        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix == null || secondMatrix == null)
            {
                throw new NullReferenceException();
            }

            if (firstMatrix.RowsCount != secondMatrix.RowsCount || firstMatrix.ColumnsCount != secondMatrix.ColumnsCount)
            {
                throw new ArgumentException("Operator substract cannot be applied to matrices with different length!");
            }

            Matrix<T> result = new Matrix<T>(firstMatrix.RowsCount, secondMatrix.ColumnsCount);

            for (int i = 0; i < result.RowsCount; i++)
            {
                for (int j = 0; j < result.ColumnsCount; j++)
                {
                    result[i, j] = (dynamic)firstMatrix[i, j] - (dynamic)secondMatrix[i, j];
                }
            }

            return result;
        }

        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.ColumnsCount != secondMatrix.RowsCount)
            {
                throw new InvalidOperationException("Matrix sizes mismatch, cannot be multiplied!");
            }

            Matrix<T> res = new Matrix<T>(firstMatrix.RowsCount, secondMatrix.ColumnsCount);

            for (int i = 0; i < res.RowsCount; i++)
            {
                for (int j = 0; j < res.ColumnsCount; j++)
                {
                    for (int k = 0; k < firstMatrix.ColumnsCount; k++)
                    {
                        res[i, j] = (T)((dynamic)res[i, j] + (dynamic)firstMatrix[i, k] * (dynamic)secondMatrix[k, j]);
                    }
                }
            }

            //Matrix<T> result = new Matrix<T>(res);
            return res;
        }

        public static bool operator true(Matrix<T> currentMatrix)
        {
            for (int i = 0; i < currentMatrix.RowsCount; i++)
            {
                for (int j = 0; j < currentMatrix.ColumnsCount; j++)
                {
                    if (currentMatrix[i,j] != (dynamic)0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool operator false(Matrix<T> currentMatrix)
        {
            for (int i = 0; i < currentMatrix.RowsCount; i++)
            {
                for (int j = 0; j < currentMatrix.ColumnsCount; j++)
                {
                    if (currentMatrix[i, j] != (dynamic)0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int row = 0; row < this.RowsCount; row++)
            {
                for (int col = 0; col < this.ColumnsCount; col++)
                {
                    result.Append(string.Format("{0, 8}", this.matrix[row, col]));   
                }

                result.AppendLine();
            }

            return result.ToString();
        }
    }
}

