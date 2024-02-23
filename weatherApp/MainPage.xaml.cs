namespace weatherApp
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnGetWeatherClicked(object sender, EventArgs e)
        {
            var weatherService = new WeatherService();
            var weatherData = await weatherService.GetWeatherAsync(cityEntry.Text);
            if (weatherData != null)
            {
                // Accessing the temperature from the Main nested class
                temperatureLabel.Text = $"Temperature: {weatherData.Main.Temp} °C";

                // Assuming there's at least one weather condition in the list and accessing the first one
                if (weatherData.Weather != null && weatherData.Weather.Any())
                {
                    conditionLabel.Text = $"Condition: {weatherData.Weather[0].Main}, {weatherData.Weather[0].Description}";
                }
            }
        }

    }
}