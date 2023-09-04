using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matrix_And_Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Navigation;
using Matrix_And_Tests.Logic;
using System.Runtime.Remoting.Messaging;

namespace Matrix_And_Tests.Tests
{
    [TestClass()]
    public class Matrix_OperationsTests
    {
        [TestMethod()]
        public void Matrix_DistinctTest_Should_Work()
        {
            ///Arrange
            TextBlock text = new TextBlock();
            Matrix_Reader reader = new Matrix_Reader();
            reader.Matrix_One = new Dictionary<int, int[]>();
            reader.Matrix_One.Add(0, new int[] { 1, 2, 3, 4 });
            reader.Matrix_One.Add(1, new int[] { 1, 2, 3, 4 });
            reader.Matrix_Two = new Dictionary<int, int[]>();
            reader.Matrix_Two.Add(0, new int[] { 1, 2, 3, 4 });
            reader.Matrix_Two.Add(1, new int[] { 1, 2, 3, 4 });

            Matrix_Operations operations = new Matrix_Operations(reader);
            ///Act
            ///
            bool isEqual = true;
            //Compare(log);
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
                    operations.Matrix_Result.Add(i, result);
                }
                foreach (var item in operations.Matrix_Result.Values)
                {
                    text.Text += string.Join(",", item) + Environment.NewLine;
                }
            }

            ///Assert
            ///Ignore Line building 
            Assert.AreEqual("0,0,0,0 0,0,0,0", text.Text);
        }

        [TestMethod()]
        public void Matrix_SumTest_ShouldShow_Equal_Result()
        {
            ///Arrange
            TextBlock text = new TextBlock();
            Matrix_Reader reader = new Matrix_Reader();
            reader.Matrix_One = new Dictionary<int, int[]>();
            reader.Matrix_One.Add(0, new int[] { 1, 2, 3, 4 });
            reader.Matrix_One.Add(1, new int[] { 1, 2, 3, 4 });
            reader.Matrix_Two = new Dictionary<int, int[]>();
            reader.Matrix_Two.Add(0, new int[] { 1, 2, 3, 4 });
            reader.Matrix_Two.Add(1, new int[] { 1, 2, 3, 4 });

            Matrix_Operations operations = new Matrix_Operations(reader);
            ///Act
            ///
            bool isEqual = true;
            //Compare(log);
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
                    operations.Matrix_Result.Add(i, result);
                }
                foreach (var item in operations.Matrix_Result.Values)
                {
                    text.Text += string.Join(",", item) + Environment.NewLine;
                }
            }

            ///Assert
            ///Ignore Line building 
            Assert.AreEqual("2,4,6,8 2,4,6,8", text.Text);
        }

        [TestMethod()]
        public void Matrix_MultTest_ShouldShow_Equal_Result()
        {
            ///Arrange
            TextBlock text = new TextBlock();
            Matrix_Reader reader = new Matrix_Reader();
            reader.Matrix_One = new Dictionary<int, int[]>();
            reader.Matrix_One.Add(0, new int[] { 1, 2, 3, 4 });
            reader.Matrix_One.Add(1, new int[] { 1, 2, 3, 4 });
            reader.Matrix_Two = new Dictionary<int, int[]>();
            reader.Matrix_Two.Add(0, new int[] { 1, 2, 3, 4 });
            reader.Matrix_Two.Add(1, new int[] { 1, 2, 3, 4 });

            Matrix_Operations operations = new Matrix_Operations(reader);
            ///Act
            ///
            bool isEqual = true;
            //Compare(log);
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
                    operations.Matrix_Result.Add(i, result);
                }
                foreach (var item in operations.Matrix_Result.Values)
                {
                    text.Text += string.Join(",", item) + Environment.NewLine;
                }
            }

            ///Assert
            ///Ignore Line building 
            Assert.AreEqual("1,4,9,16 1,4,9,16", text.Text);
        }
    }
}