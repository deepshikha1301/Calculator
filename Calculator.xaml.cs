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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Double result = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnClick(object sender, RoutedEventArgs e)
        {
            if (isOperationPerformed)
                tb.Clear();
            Button btn = (Button) sender;
            if((String)btn.Content == ".")
            {
                if (!(tb.Text.Contains (".")))
                    tb.Text += btn.Content;
            }else
            tb.Text += btn.Content;
            isOperationPerformed = false;
        }

        private void Operation(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            operationPerformed = (String)btn.Content;
            result = Double.Parse(tb.Text);
            tb.Text += btn.Content;
            isOperationPerformed = true;
        }

        private void Equals(object sender, RoutedEventArgs e)
        {
            switch(operationPerformed)
            {
                case "+":
                    tb.Text = (result + Double.Parse(tb.Text)).ToString();
                    break;
                case "-":
                    tb.Text = (result - Double.Parse(tb.Text)).ToString();
                    break;
                case "*":
                    tb.Text = (result * Double.Parse(tb.Text)).ToString();
                    break;
                case "/":
                    tb.Text = (result / Double.Parse(tb.Text)).ToString();
                    break;
            }
        }

        private void Clear_Text(object sender, RoutedEventArgs e)
        {
            tb.Clear();
            result = 0;
        }

        private void Clear_Element(object sender, RoutedEventArgs e)
        {
            tb.Clear();
        }
    }
}
