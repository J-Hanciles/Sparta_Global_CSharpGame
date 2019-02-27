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
using System.Windows.Shapes;

namespace WPFConnect4
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void GameStart_Click(object sender, RoutedEventArgs e)
        {
            PvPWindow win = new PvPWindow();
            win.Show();
        }

        private void VsComputer_Click(object sender, RoutedEventArgs e)
        {


        }

        private void InstructionBtn_Click(object sender, RoutedEventArgs e)
        {
            instructions win = new instructions();
            win.Show();
        }


    }
}
