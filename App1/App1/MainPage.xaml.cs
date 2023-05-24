using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        double firstNumber, secondNumber, result;
        string operation;

        public MainPage()
        {
            InitializeComponent();
        }


        private void OnNumberButtonClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string pressedButton = button.Text;

            if (ResultLabel.Text == "0" && pressedButton != "C")
            {
                ResultLabel.Text = "";
            }

            ResultLabel.Text += pressedButton;
        }

        private void OnClearButtonClicked(object sender, EventArgs e)
        {
            ResultLabel.Text = "0";
        }

        private void OnOperationButtonClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string pressedButton = button.Text;

            if (double.TryParse(ResultLabel.Text, out firstNumber))
            {
                operation = pressedButton;
                ResultLabel.Text = "";
            }
        }

        private void OnEqualButtonClicked(object sender, EventArgs e)
        {
            if (double.TryParse(ResultLabel.Text, out secondNumber))
            {
                switch (operation)
                {
                    case "+":
                        result = firstNumber + secondNumber;
                        break;
                    case "-":
                        result = firstNumber - secondNumber;
                        break;
                    case "*":
                        result = firstNumber * secondNumber;
                        break;
                    case "/":
                        result = firstNumber / secondNumber;
                        break;
                }

                ResultLabel.Text = result.ToString();
            }
        }
    }
}
