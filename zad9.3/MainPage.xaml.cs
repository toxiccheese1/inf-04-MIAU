using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;

namespace zad9._3
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        public MainPage()
        {
            InitializeComponent();

            
        }

        ObservableCollection <string> zakupy = new ObservableCollection <string>();
        
        private void Button_Clicked(object sender, EventArgs e)
        {
          
            if(string.IsNullOrWhiteSpace(nazwa_Produktu.Text))
            {
                DisplayAlertAsync("Błąd", "Nazwa produktu jest pusta! Proszę wpisać nazwę produktu", "OK");
            }
            else if(int.TryParse(nazwa_Produktu.Text, out int result))
            {
                DisplayAlertAsync("Błąd", "To jest liczba! Proszę wpisać poprawną nazwę produktu", "OK");
            }
            else
            {
                Lista_Zakupow.ItemsSource = zakupy;
                zakupy.Add(nazwa_Produktu.Text);
                nazwa_Produktu.Text = "";
                count++;
            }
            Label1.Text = $"Lista produktów w liście wynosi: " + count;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
           
            string r = (string)Lista_Zakupow.SelectedItem;
            zakupy.Remove(r);
            count--;
            Label1.Text = $"Lista produktów w liście wynosi: " + count;
        }
    }
}
