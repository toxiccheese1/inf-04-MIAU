
namespace zad3._3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(Produkt.Text) || !string.IsNullOrEmpty(Ilosc.Text) || !string.IsNullOrEmpty(Adres.Text))
            {
                DisplayAlertAsync("Podukt", "Produkt " + Produkt.Text + ", ilość " + Ilosc.Text + ", adres " + Adres.Text, "OK");
            }
            else
            {
                DisplayAlertAsync("Produkt", "Uzupełnij wszystkie pola", "OK");
            }
        }
    }
}
