using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace Matrix_And_Tests.Logic
{
    // не забыть поменять уровень доступа  класса
    internal class Matrix_Reader
    {
        public int[,] matrix_One;
        public int[,] matrix_Two;

        public int[,] Matrix_Two { get => matrix_Two; }
        public int[,] Matrix_One { get => matrix_One; }

        bool rightInput = false;

        public void Read(TextBox text, TextBlock log, ref int[,] mat)
        {

                string[] rows = text.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                string[] col = rows[0].Split(',');

                int[,] result = new int[rows.Length,col.Length];
                
                for (int i = 0; i < rows.Length; i++)
                {
                    string[] str = rows[i].Split(',');
                    for (int j = 0; j < str.Length; j++)
                    {
                        result[i, j] = int.Parse(str[j]);
                    }
                }
                mat = new int[rows.Length,col.Length];
                mat = result;
                rightInput = true;
                for (int i = 0; i < mat.GetLength(0); i++)
                {
                    for (int j = 0; j < mat.GetLength(1); j++)
                    {
                        log.Text+=(mat[i, j] + " ");
                    }
                    log.Text+=Environment.NewLine;
                }

            
        }
    }
}
