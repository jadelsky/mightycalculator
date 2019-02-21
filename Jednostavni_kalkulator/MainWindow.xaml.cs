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
            //char[] delimiters = new char[] { '+', '-', '*', '/', '=' };
            string[] parts = data.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
            var listOfNumbers = new List<int>();
            for (int i = 0; i <= parts.Count()-1; i=i+2)
            {
                Int32.TryParse(parts[i], out int valuesOfNumbers);
                listOfNumbers.Add(valuesOfNumbers);
            }

            var listOfOperands = new List<string>();
            for (int i = 1; i < parts.Count(); i = i + 2)
            {
                
                listOfOperands.Add(parts[i]);
            }

            int noOfOperands = listOfOperands.Count-1;
            int noOfNumbers = listOfNumbers.Count;

                            
            int resultOfOperation=listOfNumbers[0];
            for (int i = 0; i < noOfOperands; i++)
            {
                if (listOfOperands[i] == "+")
                {
                    int resultOfAdding = AddNumbers(resultOfOperation, listOfNumbers[i + 1]);
                    resultOfOperation = resultOfAdding;
                    lblMain.Content = resultOfOperation;
                    
                }
                else if (listOfOperands[i] == "-")
                {
                    int resultOfSubtracting = SubtractNumbers(resultOfOperation, listOfNumbers[i + 1]);
                    resultOfOperation = resultOfSubtracting;
                    lblMain.Content = resultOfOperation;
                }
                else if (listOfOperands[i] == "*")
                {
                    int resultOfMultiplying = MultiplyNumbers(resultOfOperation, listOfNumbers[i + 1]);
                    resultOfOperation = resultOfMultiplying;
                    lblMain.Content = resultOfOperation;
                }
                else if (listOfOperands[i] == "/")
                {
                    int resultOfDividing = DivideNumbers(resultOfOperation, listOfNumbers[i + 1]);
                    resultOfOperation = resultOfDividing;
                    lblMain.Content = resultOfOperation;
                }
            }

        }

        //funkcije operacija ->START

        public int AddNumbers(int number1, int number2)
        {
            int result = number1 + number2;
            return result;
        }

        public int SubtractNumbers(int number1, int number2)
        {
            int result = number1 - number2;
            return result;
        }

        public int MultiplyNumbers(int number1, int number2)
        {
            int result = number1 * number2;
            return result;
        }

        public int DivideNumbers(int number1, int number2)
        {
            int result = number1 / number2;
            return result;
        }


        //funkcije operacija ->STOP

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button tipka = (Button)sender;
            lblMain.Content = (string)lblMain.Content + "" + (string)tipka.Content;
            
        }
        //
        
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
           // Button tipka = (Button)sender;
            lblMain.Content = (string)lblMain.Content + " = ";
            Parse((string)lblMain.Content);

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
            lblMain.Content += " * ";

        }

        private void Button_Click_Dijeljenje(object sender, RoutedEventArgs e)
        {
            // Button tipka = (Button)sender;
            lblMain.Content += " / ";

        }
        
        private void Button_Click_Clear(object sender, RoutedEventArgs e)
        {
            // Button tipka = (Button)sender;
            lblMain.Content = "";

        }


    }
}
