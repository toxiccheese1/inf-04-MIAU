namespace zad6._3
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        public MainPage()
        {
            InitializeComponent();
        }


        private void Button_Plus(object sender, EventArgs e)
        {
            count++;
            label1.Text = $"Licznik {count}";
        }

        private void Button_Minus(object sender, EventArgs e)
        {
            if(count > 0)
            {
                count--;

            }
            label1.Text = $"Licznik {count}";

        }

        private void Button_Zeruj(object sender, EventArgs e)
        {
            count = 0;
            label1.Text = $"Licznik {count}";
        }
    }
}
