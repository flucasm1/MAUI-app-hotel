namespace MAUI_app_hotel.Views;

public partial class HospedagemContratada : ContentPage
{
	public HospedagemContratada()
	{
		InitializeComponent();
	}
	
	private async void Voltar_Hospedagem(object sender, EventArgs e)
	{
		try
		{
			await Navigation.PopAsync();
		} catch (Exception ex)
		{
			await DisplayAlertAsync("Ops", ex.Message, "OK");
		}
	}


}