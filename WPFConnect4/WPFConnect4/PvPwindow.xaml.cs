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
    public partial class PvPWindow : Window
    {
        int gridNum = 42;

        public PvPWindow()
        {
            InitializeComponent();

            int moveone = 1;//variables to use later when 
            int movetwo = 2;//the game starts for alternate turn if statements

            int player1 = moveone;//
            int player2 = movetwo;

            
                                         
        }        
        
        private void NewGameBtn_Click(object sender, RoutedEventArgs e)
        {
            foreach (Control ctrl in connect4Table.Children)
            {
                if (Background == Brushes.Red)
                {
                    
                }
            }



            for (int i = 0; i < 42; i++)//the amount of buttons in grid
            {




            }
        }

        private void R0C0_Click(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)e.Source;

            if (gridNum % 2 == 0)
            {
                if ((bt.Background == Brushes.LightGray))
                {
                    bt.Background = Brushes.Black;//applied to all buttons
                    gridNum--;
                    checkWin(bt.Tag.ToString());
                }
                
            }
            else if (gridNum % 2 == 1)
            {
                if ((bt.Background == Brushes.LightGray))
                {
                    bt.Background = Brushes.Red;//applied to all buttons
                    gridNum--;
                    checkWin(bt.Tag.ToString());
                }
                
            }
            
            
        }

        private void checkWin(string tag)
        {
            if (tag == "00" )
            {
                if(R0C0.Background.ToString() == R0C1.Background.ToString() && R0C1.Background.ToString() == R0C2.Background.ToString() && R0C2.Background.ToString() == R0C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }





            }

        }

    }
        
}

