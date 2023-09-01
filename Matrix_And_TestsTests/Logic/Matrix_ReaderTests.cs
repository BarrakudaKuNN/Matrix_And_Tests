using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matrix_And_Tests.Logic;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Matrix_And_Tests.Logic.Tests
{
    [TestClass()]
    public class Matrix_ReaderTests
    {
        [TestMethod()]
        public void ReadTestShoud_Work_Well()
        {
            //arrange
            TextBox textBox = new TextBox();
            textBox.Text = "1,2,3" + Environment.NewLine + "2,3,4";
            TextBlock textBlock = new TextBlock();
            textBlock.Text = "";
            Matrix_Reader matrix_Reader = new Matrix_Reader();

            //act
            matrix_Reader.Read(textBox, textBlock,matrix_Reader.Matrix_One);

            //assert
            Assert.IsTrue(matrix_Reader.Matrix_One.TryGetValue(0, out int[] value));
            Assert.IsTrue(matrix_Reader.Matrix_One.TryGetValue(1, out int[] value2));
            CollectionAssert.AreEqual(new int[] { 1, 2, 3 }, value);
            CollectionAssert.AreEqual(new int[] { 2, 3, 4 }, value2);
        }
        [TestMethod()]
        public void ReadTestShoud_Show_Exeption()
        {
            //arrange
            TextBox textBox = new TextBox();
            textBox.Text = "Еуч" + Environment.NewLine + "2,3,4,,ew4,4";
            TextBlock textBlock = new TextBlock();
            Matrix_Reader matrix_Reader = new Matrix_Reader();
            textBlock.Text = textBox.Text;

            //act
            matrix_Reader.Read(textBox, textBlock, matrix_Reader.Matrix_One);
            //assert
            Assert.AreNotEqual(textBlock.Text, textBox.Text);
            //"Input string was not in a correct format."
        }
    }
}