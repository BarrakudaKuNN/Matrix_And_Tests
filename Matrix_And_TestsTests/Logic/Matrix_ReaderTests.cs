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
            TextBox textBox1 = new TextBox();
            TextBox textBox2 = new TextBox();
            textBox1.Text = "1,2,3" + Environment.NewLine + "2,3,4";
            textBox2.Text = "1,2,3" + Environment.NewLine + "2,3,4";
            TextBlock textBlock = new TextBlock();
            textBlock.Text = "";
            Matrix_Reader matrix_Reader = new Matrix_Reader();

            //act
            matrix_Reader.Read(textBox1, textBlock, ref matrix_Reader.matrix_One);
            matrix_Reader.Read(textBox2, textBlock, ref matrix_Reader.matrix_Two);
            //assert
            //Ignoring Ui Show, we care only about results
            Assert.AreEqual("1 2 3 \n2 3 4 \n1 2 3 \n2 3 4", textBlock.Text);
            
        }
        [TestMethod()]
        public void ReadTestShoud_Show_Exeption()
        {
            //arrange
            TextBox textBox = new TextBox();
            textBox.Text = "Еуч" + Environment.NewLine + "2,3,4,,ew4,4";
            TextBlock textBlock = new TextBlock();
            textBlock.Text = "";
            Matrix_Reader matrix_Reader = new Matrix_Reader();

            //act
            matrix_Reader.Read(textBox, textBlock, ref matrix_Reader.matrix_One);
            //assert
           
            Assert.ThrowsException<FormatException>(()=>matrix_Reader.Read (textBox, textBlock, ref matrix_Reader.matrix_One));
            //"Input string was not in a correct format."
        }
    }
}