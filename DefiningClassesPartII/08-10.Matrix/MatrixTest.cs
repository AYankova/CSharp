namespace Matrix
{
    using System;

    class MatrixTest
    {
        static void Main()
        {
            Matrix<int> intMatrix1 = new Matrix<int>(new int[,] 
        {   {  9,  8,  7 }, 
            {  6,  5,  4 }, 
            {  3,  2,  1 }, 
        });

            Matrix<int> intMatrix2 = new Matrix<int>(new int[,] 
        {   {  1,  2,  3 }, 
            {  4,  5,  6 }, 
            {  7,  8,  9 }, 
        });

            Matrix<int> intMatrix3 = new Matrix<int>(4, 3);

            Matrix<double> doubleMatrix1= new Matrix<double>(new double[,] 
        {   { 12.1, 11.2, 10.3 }, 
            {  9.4,  8.5,  7.6 }, 
            {  6.7,  5.8,  4.9 }, 
            {  3.0,  2.1,  1.2 }
        });

            Matrix<double> doubleMatrix2 = new Matrix<double>(new double[,] 
        {   {  1.1,  2.2,  3.3, 4.4 }, 
            {  5.5,  6.6,  7.7, 8.8 }, 
            {  9.9, 10.0, 11.1, 12.2 } 
        });

            if (intMatrix1 )
            {
                Console.WriteLine("This will be printed, non-zero values");
                Console.WriteLine(intMatrix1); 
            }

            if (intMatrix3)
            {
                //This won't be printed, zero values
                Console.WriteLine(intMatrix3);
            }

            Console.WriteLine("Result of addition of integer matrices");
            Console.WriteLine(intMatrix1+intMatrix2);
            Console.WriteLine();
            Console.WriteLine("Result of substraction of integer matrices");
            Console.WriteLine(intMatrix1 - intMatrix2);
            Console.WriteLine();
            Console.WriteLine("Result of multiplying of integer matrices");
            Console.WriteLine(intMatrix1 * intMatrix2);
            Console.WriteLine();
            Console.WriteLine("Result of multiplying of double matrices");
            Console.WriteLine(doubleMatrix1 * doubleMatrix2);
        }
    }
}
