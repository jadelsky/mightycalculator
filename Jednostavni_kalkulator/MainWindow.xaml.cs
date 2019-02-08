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

namespace Jednostavni_kalkulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            //DELAS THE SAILOR MAN
        }

        private void Parse(string data)
        {
            char[] delimiters = new char[] { '+', '-', '*', '/' };
            string[] parts = data.Split(delimiters);
            string[] parts2 = data.Split(' ');            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button tipka = (Button)sender;
            lblMain.Content = (string)lblMain.Content + "" + (string)tipka.Content;
        }
        //
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
           // Button tipka = (Button)sender;
            Parse((string)lblMain.Content);
            //lblMain.Content =  " = ";

        }

        private void Button_Click_Zbrajanje(object sender, RoutedEventArgs e)
        {
            // Button tipka = (Button)sender;
            lblMain.Content += " + ";

        }
        private void Button_Click_Oduzimanje(object sender, RoutedEventArgs e)
        {
            // Button tipka = (Button)sender;
            lblMain.Content += " - ";

        }

        private void Button_Click_Mnozenje(object sender, RoutedEventArgs e)
        {
            // Button tipka = (Button)sender;
            lblMain.Content = " * ";

        }

        private void Button_Click_Dijeljenje(object sender, RoutedEventArgs e)
        {
            // Button tipka = (Button)sender;
            lblMain.Content = " / ";

        }

        private void Button_Click_Clear(object sender, RoutedEventArgs e)
        {
            // Button tipka = (Button)sender;
            lblMain.Content = " ";

        }


    }
}
