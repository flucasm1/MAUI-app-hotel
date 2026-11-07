
namespace MAUI_app_hotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    App PropriedadesApp;

    public ContratacaoHospedagem()
    {
        InitializeComponent();

        PropriedadesApp = (App)Application.Current;

        pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;

        dtpck_checkin.MinimumDate = DateTime.Today;
        dtpck_checkin.MaximumDate = DateTime.Today.AddMonths(1);

        DateTime data_checkin = dtpck_checkin.Date ?? DateTime.Today;

        dtpck_checkout.MaximumDate = data_checkin.AddMonths(6);
        dtpck_checkout.MinimumDate = data_checkin.AddDays(1);
    }

    private async void OnSobreClicked(object sender, EventArgs e)
    {
        try
        {
            await Navigation.PushAsync(new Sobre());
        }
        catch (Exception ex)
        {
            await DisplayAlertAsync("Ops", ex.Message, "OK");
        }
    }

    private async void OnAvancarClicked(object sender, EventArgs e)
    {
        try
        {
            await Navigation.PushAsync(new HospedagemContratada());
        }
        catch (Exception ex)
        {
            await DisplayAlertAsync("Ops", ex.Message, "OK");
        }
    }

    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;

        DateTime data_selecionada_checkin = elemento.Date ?? DateTime.Today;

        DateTime data_minima = data_selecionada_checkin.AddDays(1);
        DateTime data_maxima = data_selecionada_checkin.AddMonths(6);

        dtpck_checkout.MaximumDate = data_maxima;
        dtpck_checkout.MinimumDate = data_minima;

        if (dtpck_checkout.Date == null ||
            dtpck_checkout.Date < data_minima ||
            dtpck_checkout.Date > data_maxima)
        {
            dtpck_checkout.Date = data_minima;
        }
    }
}
