namespace inf_04_MIAU
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Zmien_Clicked(object sender, EventArgs e)
        {
            Label1.Text = "Dziękujemy za uruchomienie aplikacji";
            count++;
            counter1.Text = "Łącznie kliknięto oba przyciski " + count + " razy!";
        }

        private void Reset_Clicked(object sender, EventArgs e)
        {
            Label1.Text = "Witamy w aplikacji";
            count++;
            counter1.Text = "Łącznie kliknięto oba przyciski " + count + " razy!";
        }
    }
}
