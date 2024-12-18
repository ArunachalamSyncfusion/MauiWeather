using MauiWeather.Views;

namespace MauiWeather
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new WeatherView());
        }
    }
}