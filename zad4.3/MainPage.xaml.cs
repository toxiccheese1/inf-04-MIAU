namespace zad4._3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string w;
            string c;
            string f = "nie wybrano";
            if((!string.IsNullOrEmpty(Imie.Text)) && (!string.IsNullOrEmpty(Nazwisko.Text)))
            {
            if(stac.IsChecked)
                {
                    f = "Stacjonarny";
                }
                else if (On.IsChecked)
                {
                    f = "Online";
                }
                else if (hyb.IsChecked)
                {
                    f = "Hybrydowy";
                }
                if (Wiedza.IsChecked)
            {
                w = "posiada podstawową wiedzę";
            }
            else
            {
                w = "nie posiada podstawowej wiedzy";
            }
            if (Certyfikat.IsToggled)
            {
                c = "chce otrzymać certyfikat";
            }
            else
            {
                c = "nie chce otrzymać certyfikatu";
            }
            Info.Text = "Imię " + Imie.Text + ", Nazwisko " + Nazwisko.Text + " "+w+", "+c+", forma kursu "+f+" oraz oczekiwania "+Ed.Text+"!";
            }
            else
            {
                Info.Text = "Podaj imię i nazwisko!";
            }
        }
    }
}
