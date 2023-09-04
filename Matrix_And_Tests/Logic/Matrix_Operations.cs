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
    public class Matrix_Operations
    {
        Matrix_Reader reader;

        private Dictionary<int, int[]> matrix_Result = new Dictionary<int, int[]>();
        public Dictionary<int, int[]> Matrix_Result { get => matrix_Result; set => matrix_Result = value; }
        public Matrix_Operations(Matrix_Reader reader)
        {
            this.reader = reader;
        }

       public bool isEqual;
        // Dont forget to change for private after tests
        public void Compare(TextBlock text)
        {
           
            if (reader.Matrix_One.Keys.Count == reader.Matrix_Two.Keys.Count)
            {
                for (int i = 0; i < reader.Matrix_One.Keys.Count; i++)
                {
                    int[] o;
                    int[] s;
                    int d = reader.Matrix_One.Values.Count;
                    reader.Matrix_One.TryGetValue(i, out o);
                    reader.Matrix_Two.TryGetValue(i, out s);

                    if (s.Length != o.Length)
                    {
                        isEqual = false;
                        text.Text = "Матрицы различны по длине";
                        break;
                    }
                    else
                    {
                        text.Text = "Матрицы равны по длине";
                        isEqual = true;
                    }
                }
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
                for (int i = 0; i < reader.Matrix_One.Keys.Count; i++)
                {
                    int[] one;
                    int[] sec;
                    reader.Matrix_One.TryGetValue(i, out one);
                    reader.Matrix_Two.TryGetValue(i, out sec);
                    int[] result = new int[one.Length];
                    for (int j = 0; j < one.Length; j++)
                    {
                        result[j] = one[j] + sec[j];
                    }
                    matrix_Result.Add(i,result);
                }
                foreach (var item in matrix_Result.Values)
                {
                    log.Text += Environment.NewLine + string.Join(",", item);
                }
            }
        }
        public void Matrix_Distinct(TextBlock log)
        {
            Compare(log);
            if (isEqual)
            {
                for (int i = 0; i < reader.Matrix_One.Keys.Count; i++)
                {
                    int[] one;
                    int[] sec;
                    reader.Matrix_One.TryGetValue(i, out one);
                    reader.Matrix_Two.TryGetValue(i, out sec);
                    int[] result = new int[one.Length];
                    for (int j = 0; j < one.Length; j++)
                    {
                        result[j] = one[j] - sec[j];
                    }
                    matrix_Result.Add(i, result);
                }
                foreach (var item in matrix_Result.Values)
                {
                    log.Text += Environment.NewLine + string.Join(",", item);
                }
            }
        }
        public void Matrix_Mult(TextBlock log)
        {
            Compare(log);
            if (isEqual)
            {
                for (int i = 0; i < reader.Matrix_One.Keys.Count; i++)
                {
                    int[] one;
                    int[] sec;
                    reader.Matrix_One.TryGetValue(i, out one);
                    reader.Matrix_Two.TryGetValue(i, out sec);
                    int[] result = new int[one.Length];
                    for (int j = 0; j < one.Length; j++)
                    {
                        result[j] = one[j] * sec[j];
                    }
                    matrix_Result.Add(i, result);
                }
                foreach (var item in matrix_Result.Values)
                {
                    log.Text += Environment.NewLine+ string.Join(",", item) ;
                }
            }
        }

        public void Clear()
        {
            reader.Matrix_One.Clear();
            reader.Matrix_Two.Clear();
            matrix_Result.Clear();
        }
    }
}
