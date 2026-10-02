namespace zad8._3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double pole;
            if (double.TryParse(Szerok.Text, out double S) && double.TryParse(Wysok.Text, out double W)&&(S > 0)&&(W > 0))
            {
                pole = (S + W) / 2;
                Label1.Text = $"Pole prostokąta wynosi: {pole} cm2";
            }
            else
            {
                DisplayAlertAsync("Błąd!", "Niepoprawne liczby", "OK");
            }
        }
        private async void Button_Clicked1(object sender, EventArgs e)
        {
            bool sprawdz = await DisplayAlertAsync("Potwierdź", "Czy aby na pewno chcesz wyczyścić dane?", "Tak, chcę", "Anuluj");
            if (sprawdz)
            {
                Label1.Text = "";
                Szerok.Text = "";
                Wysok.Text = "";
            }
        }
    }
}
