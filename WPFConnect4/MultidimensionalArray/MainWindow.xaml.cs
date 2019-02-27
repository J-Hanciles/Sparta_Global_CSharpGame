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

namespace MultidimensionalArray
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        

            int[][] intJaggedArray = new int[2][];

            intJaggedArray[0] = new int[3]{1, 2, 3};

            intJaggedArray[1] = new int[2]{4, 5 };

            Console.WriteLine(intJaggedArray[0][0]); // 1

            Console.WriteLine(intJaggedArray[0][2]); // 3
    
            Console.WriteLine(intJaggedArray[1][1]); // 5
        }
    }
}
