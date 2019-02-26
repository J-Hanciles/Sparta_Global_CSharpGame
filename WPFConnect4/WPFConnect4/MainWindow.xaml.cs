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

namespace WPFConnect4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            int moveone = 1;
            int movetwo = 2;

            int player1 = moveone;
            int player2 = movetwo;


            //int connect4TableContents = connect4Table.RowDefinitions.Count;

            InitializeComponent();


            /*for (int i = 0; i < connect4Table.ColumnDefinitions.Count; i++)
            {

                for (int x = 0; x < connect4Table.RowDefinitions.Count; x++)
                {
                    TextBlock btc = new TextBlock();
                    btc.Background = Brushes.Black;

                    TextBlock rtc = new TextBlock();
                    rtc.Background = Brushes.Red;

                    if (true)
                    {

                    }

                    Grid.SetColumn(btc, i);
                    connect4Table.Children.Add(btc);


                }

            }*/

                                                         
        }

        private void InstructionsBtn_Click(object sender, RoutedEventArgs e)
        {
            instructions win = new instructions();
            win.Show();

            
        }

        private void R5C0_Click(object sender, RoutedEventArgs e)
        {
            
            R0C5.Background = Brushes.Red;
        }
    }
        
}

