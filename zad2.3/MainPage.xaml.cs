namespace zad2._3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(Miasto.Text) && !string.IsNullOrEmpty(Imie.Text))
            {
                PokazMiasto.Text = "Witaj "+Imie.Text+"! Pozdrowienia z miasta " + Miasto.Text;
            }
            else
            {
                PokazMiasto.Text = "Uzupełnij oba pola!";
            }
        }
    }
}