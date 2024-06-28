namespace MeridyenTente
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnTransitionButtonClicked(object sender, EventArgs e)
        {
            switch (sender is Button clickedbutton ? clickedbutton.Text : "Error")
            {
                case "Cam Balkon":
                    await Navigation.PushAsync(new GlassBalconySystem());
                    break;
                case "Giyotin":
                    await Navigation.PushAsync(new GuillotineSystem());
                    break;
                case "Tente":
                    await Navigation.PushAsync(new TenteSystem());
                    break;
            }
        }
    }

}
