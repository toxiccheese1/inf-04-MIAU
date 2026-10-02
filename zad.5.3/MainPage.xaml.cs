namespace zad._5._3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            if(Picker.SelectedIndex == 0 || Picker.SelectedIndex == 1 || Picker.SelectedIndex == 2)
            {
                Info.Text = "Wybrana "+Picker.SelectedItem+" Liczba osob "+Liczba_osob.Value+$" Data {data.Date:dd.MM.yyyy}";
            }
            else
            {
                Info.Text = "Wybierz salę!";
            }
        }

        private void Stepper_Changed(object sender, ValueChangedEventArgs e)
        {
            Label1.Text = $"Ilość osób: {Liczba_osob.Value}";
        }

        private void data_DateSelected(object sender, DateChangedEventArgs e)
        {
            Label2.Text = $"Wybrana data: {data.Date:dd.MM.yyyy}";
        }
    }
}
