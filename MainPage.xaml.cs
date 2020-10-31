using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AwesomeApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        //int count = 0;
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            //var height = double.Parse(inputHeight.Text);
            //var weight = double.Parse(inputWeight.Text);
            //var bmi = (weight / (height * height)) * 703;
            //((Button)sender).Text = $"Your BMI is: {bmi}";

            //Belgium(16), China(18), Canada(19), Japan(20)
            var today = DateTime.Today;
            var birthday = Convert.ToDateTime(inputBirthday.Text);
            var age = today.Year - birthday.Year;
            var legalAge = 21 - age;
            var userCountry = inputCountry.Text.ToUpper();


            switch (userCountry)
            {
                case "B":
                    if (age > 15)
                    {
                        ((Button)sender).Text = $"You can already drink in Belgium!";
                    }
                    else
                    {
                        ((Button)sender).Text = $"Years until you can drink in Belguim: {16 - age}";
                    }
                    break;
                case "C":
                    if (age > 17)
                    {
                        ((Button)sender).Text = $"You can already drink in China!";
                    }
                    else
                    {
                        ((Button)sender).Text = $"Years until you can drink in China: {18 - age}";
                    }
                    break;
                case "CA":
                    if (age > 18)
                    {
                        ((Button)sender).Text = $"You can already drink in Canada!";
                    }
                    else
                    {
                        ((Button)sender).Text = $"Years until you can drink in Canada: {19 - age}";
                    }
                    break;
                case "J":
                    if (age > 19)
                    {
                        ((Button)sender).Text = $"You can already drink in Japan!";
                    }
                    else
                    {
                        ((Button)sender).Text = $"Years until you can drink in Japan: {20 - age}";
                    }
                    break;
                case "U":
                    if (age > 20)
                    {
                        ((Button)sender).Text = $"You can already drink in the USA!";
                    }
                    else
                    {
                        ((Button)sender).Text = $"Years until you can drink in USA: {21 - age}";
                    }
                    break;
            }


        }
    }
}
