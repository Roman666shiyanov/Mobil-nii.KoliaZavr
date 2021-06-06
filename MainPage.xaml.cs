using System;
using Xamarin.Forms;

namespace Kolj
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public double kW(double с)
        {
            double k = с * 100 /13;
			return k;
        }
        public void Submit_Clicked(object sender, EventArgs e)
        {
            try
            {
                double a = SW(Convert.ToDouble(First.Text));
                double result = a;

                Page1 secondpage = new Page1();
                Navigation.PushAsync(secondpage);
                secondpage.Calculator(result);
            }
            catch (FormatException)
            {
                DisplayAlert("Ошибка", "Ошибка введенных данных!", "Ввести заново");
            }
        }
    }

}


