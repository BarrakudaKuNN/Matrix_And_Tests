﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matrix_And_Tests.Logic;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
            Matrix_Reader matrix_Reader = new Matrix_Reader();

            //act
            matrix_Reader.Read(textBox, textBlock);

            //assert
            Assert.AreEqual(2, matrix_Reader.Matrix_One.Values);
            CollectionAssert.AreEqual(new int[] { 1, 2, 3 }, matrix_Reader.Matrix_One.Values);
            CollectionAssert.AreEqual(new int[] { 4, 5, 6 }, matrix_Reader.Matrix_One.Values);
        }
        [TestMethod()]
        public void ReadTestShoud_Work_With_Exeption()
        {
            //arrange
            TextBox textBox = new TextBox();
            textBox.Text = "1,2,3" + Environment.NewLine + "2,3,4,,ew4,4";
            TextBlock textBlock = new TextBlock();
            Matrix_Reader matrix_Reader = new Matrix_Reader();

            //act
            matrix_Reader.Read(textBox, textBlock);

            //assert
            Assert.AreEqual(2, matrix_Reader.Matrix_One);
            CollectionAssert.AreEqual(new int[] { 1, 2, 3 }, matrix_Reader.Matrix_One);
            CollectionAssert.AreEqual(new int[] { 4, 5, 6 }, matrix_Reader.Matrix_One);
        }
    }
}