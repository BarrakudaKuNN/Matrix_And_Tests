﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Matrix_And_Tests.Logic
{
    // не забыть поменять уровень доступа  класса
    public class Matrix_Reader
    {
        private Dictionary<int, int[]> matrix_One = new Dictionary<int, int[]>();
        private Dictionary<int, int[]> matrix_Two = new Dictionary<int, int[]>();

        public Dictionary<int, int[]> Matrix_One { get => matrix_One; set => matrix_One = value; }
        public Dictionary<int, int[]> Matrix_Two { get => matrix_Two; set => matrix_Two = value; }

        public void Read(TextBox text, TextBlock log, Dictionary<int, int[]> dic)
        {
            try
            {
                //lines Это мы раделили строки между собой
                string[] lines = text.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

                for (int i = 0; i < lines.Length; i++)
                {

                    // str это мы разобрали отдельную строку
                    string[] str = lines[i].Split(',');
                    int[] numbers = new int[str.Length];

                    for (int j = 0; j < str.Length; j++)
                    {
                        numbers[j] = int.Parse(str[j]);
                    }
                    dic.Add(i, numbers);
                }

            }
            catch(Exception ex)
            {
                log.Text=ex.Message;
            }
            int[,] matrix = new int[,] 
            {
                    {1, -2, 3},
                    {-4, 5, 6},
                     {7, 8, -9},
                     {9, 10, 11},
                     {2,3,4},
            };
        }
    }
}
