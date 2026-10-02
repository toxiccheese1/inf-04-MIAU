
namespace zad10._3
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            int slider = (int)Slider.Value;
            Content.BackgroundColor = Color.FromRgb(slider, slider, slider);
            if(slider < 128)
            {
                Label1.TextColor = Color.FromRgb(255, 255, 255);
            }
            else
            {
                Label1.TextColor = Color.FromRgb(0, 0, 0);
            }

        }
    }
}
