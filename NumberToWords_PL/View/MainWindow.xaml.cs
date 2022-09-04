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
using LiczbyNaSlowaNETCore;

namespace NumberToWords_PL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBoxBase_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                var textBox = sender as TextBox;
                var numberToConvert = Convert.ToDecimal(textBox?.Text);
                var result = NumberToText.Convert(numberToConvert, Currency.PLN, true);

                ResultTextBlock.Text = result;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }
    }
}