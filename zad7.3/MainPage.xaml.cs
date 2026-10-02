

using System.Numerics;

namespace zad7._3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ValueChanged(object sender, ValueChangedEventArgs e)
        {
            byte s1 = (byte)Slider1.Value;
            byte s2 = (byte)Slider2.Value;
            byte s3 = (byte)Slider3.Value;
            Content.Background = Color.FromRgb(s1, s2, s3);
            Label1.Text = $"W systemie szesnastkowym: #{s1.ToString("X2")}{s2.ToString("X2")}{s3.ToString("X2")}";
        }
    }
}
