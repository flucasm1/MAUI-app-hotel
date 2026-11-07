using MAUI_app_hotel.Models;

namespace MAUI_app_hotel
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto> 
        {
            new Quarto { Descricao = "Suíte Simples", ValorAdulto = 100.00, ValorCrianca = 50.00 },
            new Quarto { Descricao = "Suíte Dupla", ValorAdulto = 150.00, ValorCrianca = 75.00 },
            new Quarto { Descricao = "Suíte Confortável", ValorAdulto = 200.00, ValorCrianca = 100.00 },
            new Quarto { Descricao = "Suíte  Luxo", ValorAdulto = 300.00, ValorCrianca = 150.00 }
        };

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;


        }
    }
}
        