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
    internal class Matrix_Operations
    {
        Matrix_Reader reader;

        private Dictionary<int, int[]> matrix_Result = new Dictionary<int, int[]>();
        public Dictionary<int, int[]> Matrix_Result { get => matrix_Result; set => matrix_Result = value; }
        public Matrix_Operations(Matrix_Reader reader)
        {
            this.reader = reader;
        }

        bool isEqual;
        void Compare(TextBlock text)
        {
            //foreach (var item in reader.Matrix_One.Keys.Intersect(reader.Matrix_One.Keys))
            //{
            //    if (reader.Matrix_One[item].Length != reader.Matrix_Two[item].Length)
            //    {
            //        isEqual = false;
            //        break;
            //    }
            //}
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
                    log.Text += string.Join(",", item) + Environment.NewLine;
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
                    log.Text += string.Join(",", item) + Environment.NewLine;
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
                    log.Text += string.Join(",", item) + Environment.NewLine;
                }
            }
        }
    }
}
