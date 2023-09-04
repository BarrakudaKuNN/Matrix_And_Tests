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
        public void Matrix_Sum_Test_Should_Work()
        {
            /////Arrange
            Matrix_Reader reader = new Matrix_Reader();
            Matrix_Operations operations = new Matrix_Operations(reader);
            reader.matrix_One = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            reader.matrix_Two = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            TextBlock text1=new TextBlock();
            TextBlock text2=new TextBlock();


            //Matrix_Operations operations = new Matrix_Operations(reader);
            /////Act
            operations.Matrix_Sum(text1);


            /////Assert
            ///Watch at text1.Text and see result
            Assert.AreEqual("0,0,0,0 0,0,0,0", text1.Text);
        }

        [TestMethod()]
        public void Matrix_Mult_Test_Should_Work()
        {
            /////Arrange
            Matrix_Reader reader = new Matrix_Reader();
            Matrix_Operations operations = new Matrix_Operations(reader);
            reader.matrix_One = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            reader.matrix_Two = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            TextBlock text1 = new TextBlock();
            TextBlock text2 = new TextBlock();


            //Matrix_Operations operations = new Matrix_Operations(reader);
            /////Act
            operations.Matrix_Mult(text1);


            /////Assert
            ///Watch at text1.Text and see result
            Assert.AreEqual("0,0,0,0 0,0,0,0", text1.Text);
        }

        [TestMethod()]
        public void Matrix_Distinct_Test_Should_Work()
        {
            /////Arrange
            Matrix_Reader reader = new Matrix_Reader();
            Matrix_Operations operations = new Matrix_Operations(reader);
            reader.matrix_One = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            reader.matrix_Two = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            TextBlock text1 = new TextBlock();
            TextBlock text2 = new TextBlock();


            //Matrix_Operations operations = new Matrix_Operations(reader);
            /////Act
            operations.Matrix_Distinct(text1);


            /////Assert
            ///Watch at text1.Text and see result
            Assert.AreEqual("0,0,0,0 0,0,0,0", text1.Text);
        }

        [TestMethod()]
        public void CompareTest()
        {
            // Не тестируемый метод, в нём не смысла
            Assert.Fail();
        }
    }
}