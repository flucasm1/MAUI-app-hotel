using Microsoft.Extensions.DependencyInjection;

namespace MAUI_app_hotel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
        protected override Window CreateWindow(IActivationState? activationState)
        {
            var widow = base.CreateWindow(activationState);

            Window.WidthProperty = 400;
            Window.HeightProperty = 600;

            return widow;
        }
    }
}