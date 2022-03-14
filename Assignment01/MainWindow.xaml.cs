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

namespace Assignment01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 


    public partial class MainWindow : Window
    {

        int total;

        Random Random = new Random();
        int randomNumber;

        int win = 0;
        int lose = 0;


        public MainWindow()
        {
            InitializeComponent();
            checkButton.IsEnabled = false;
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            randomNumber = Random.Next(0, 511);

            questionTxt.Content = "What is " + randomNumber + " in Binary?";

            checkButton.IsEnabled = true;

            answerTxt.Content = "";

            foreach (var x in g1.Children.OfType<TextBox>())
            {
                x.Text = "0";
            }
        }

        private void checkAnswer(object sender, RoutedEventArgs e)
        {
            total = 0;

            answerTxt.Content = "";

            foreach (var x in g1.Children.OfType<TextBox>())
            {
                

                if (x.Text == "1")
                {
                    total += Convert.ToInt32(x.Tag);                    
                }

                answerTxt.Content += x.Text;
            }

            if (total == randomNumber)
            {
                win++;
                checkButton.IsEnabled = false;
                answerTxt.Content += "  is correct!";
                l2.Content = win;
                
            }
            else
            {
                lose++;
                l1.Content = lose;
                answerTxt.Content += "  is incorrect!";
            }

        }
    
    }
}
