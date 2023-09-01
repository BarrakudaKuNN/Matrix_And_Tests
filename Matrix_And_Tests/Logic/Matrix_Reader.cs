using System;
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
        Dictionary<int, int[]> matrix_Two = new Dictionary<int, int[]>();

        public Dictionary<int, int[]> Matrix_One { get => matrix_One; set => matrix_One = value; }

        public void Read(TextBox text, TextBlock log)
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
                    Matrix_One.Add(i, numbers);
                }

            }
            catch(Exception ex)
            {
                log.Text=ex.Message;
            }

           
        }
        //foreach (var item in matrix_One.Values)
        //{
        //    log.Text += string.Join(",", item) +Environment.NewLine;
        //}
    }
}
