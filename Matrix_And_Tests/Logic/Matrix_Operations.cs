using Matrix_And_Tests.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using static System.Net.Mime.MediaTypeNames;

namespace Matrix_And_Tests
{
    /// <summary>
    /// Dont Forget to Change to Internal
    /// </summary>
    internal class Matrix_Operations
    {
        Matrix_Reader reader;

        int[,] matrix_Result;
       
        public Matrix_Operations(Matrix_Reader reader)
        {
            this.reader = reader;
        }

       public bool isEqual;

        public int[,] Matrix_Result { get => matrix_Result; set => matrix_Result = value; }

        // Dont forget to change for private after tests
        void Compare(TextBlock text)
        {
           
            if (reader.Matrix_One.GetLength(0) == reader.Matrix_Two.GetLength(0) && reader.Matrix_One.GetLength(1) == reader.Matrix_Two.GetLength(1))
            {
                text.Text = "Матрицы равны";
                isEqual = true;
            }
            else
            {
                text.Text = "Матрицы не равны";
                isEqual = false;
            }
            
        }

        public void Matrix_Sum(TextBlock log)
        {
            Compare(log);
            if (isEqual)
            {
                int rows = reader.Matrix_One.GetLength(0);
                int cols = reader.Matrix_One.GetLength(1);
                matrix_Result = new int[rows, cols];
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        matrix_Result[i, j] = reader.Matrix_One[i,j] + reader.Matrix_Two[i,j];
                    }
                }
                //выводим результат

                for (int i = 0; i < rows; i++)
                {
                    log.Text += Environment.NewLine;
                    for (int j = 0; j < cols; j++)
                    {
                        log.Text += (matrix_Result[i,j] + " ");
                    }
                }
            }
        }
        public void Matrix_Distinct(TextBlock log)
        {
            Compare(log);
            if (isEqual)
            {
                int rows = reader.Matrix_One.GetLength(0);
                int cols = reader.Matrix_One.GetLength(1);
                matrix_Result = new int[rows, cols];
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        matrix_Result[i, j] = reader.Matrix_One[i, j] - reader.Matrix_Two[i, j];
                    }
                }
                //выводим результат

                for (int i = 0; i < rows; i++)
                {
                    log.Text += Environment.NewLine;
                    for (int j = 0; j < cols; j++)
                    {
                        log.Text += (matrix_Result[i, j] + " ");
                    }
                }
            }
        }
        public void Matrix_Mult(TextBlock log)
        {
            Compare(log);
            if (isEqual)
            {
                int rows = reader.Matrix_One.GetLength(0);
                int cols = reader.Matrix_One.GetLength(1);
                matrix_Result = new int[rows, cols];
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        matrix_Result[i, j] = reader.Matrix_One[i, j] * reader.Matrix_Two[i, j];
                    }
                }
                //выводим результат

                for (int i = 0; i < rows; i++)
                {
                    log.Text += Environment.NewLine;
                    for (int j = 0; j < cols; j++)
                    {
                        log.Text += (matrix_Result[i, j] + " ");
                    }
                }
            }
        }

        public void Clear(Matrix_Reader reader)
        {
            reader.matrix_One = new int[0, 0];
            reader.matrix_Two = new int[0, 0];
            Matrix_Result = new int[0, 0];
        }
    }
}
