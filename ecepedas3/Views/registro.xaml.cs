namespace ecepedas3.Views;

public partial class registro : ContentPage
{


    public registro()
	{
		InitializeComponent();
	}

	private async void btnGuardar_Clicked(object sender, EventArgs e)
	{
		try
		{
			 string usuarioNuevo = txtUsuarioNuevo.Text;
			 string contrasenaNueva = txtContrasenaNueva.Text;
			await Navigation.PushAsync(new login(usuarioNuevo, contrasenaNueva));
			await DisplayAlertAsync("Alerta", "Usuario guardado", "Cerrar");
		}
		catch (Exception ex)
		{
			throw;
		}
	}
}