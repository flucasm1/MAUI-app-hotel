namespace MAUI_app_hotel.Views;


public partial class ContratacaoHospedagem : ContentPage
{
	public ContratacaoHospedagem()
	{
		InitializeComponent();
	}
    private async void OnSobreClicked(object sender, EventArgs e) {
        try
        {
            await Navigation.PushAsync(new Sobre());
        } catch(Exception ex)
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
}