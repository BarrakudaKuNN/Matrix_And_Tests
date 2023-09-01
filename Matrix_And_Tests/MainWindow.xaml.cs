using Matrix_And_Tests.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Matrix_And_Tests
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Matrix_Reader reader;
        Matrix_Operations operations;
        public MainWindow()
        {
            InitializeComponent();
            reader = new Matrix_Reader();
            operations = new Matrix_Operations(reader);
        }

        private void Button_Do_Something_Click(object sender, RoutedEventArgs e)
        {
            reader.Read(TextBox_M1, Text_Block_Error, reader.Matrix_One);
            reader.Read(TextBox_M2, Text_Block_Error, reader.Matrix_Two);
            
            operations.Matrix_Sum(Text_Block_Error);
            
        }
    }
}
