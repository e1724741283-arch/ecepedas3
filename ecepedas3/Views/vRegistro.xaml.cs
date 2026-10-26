namespace ecepedas3.Views;

public partial class vRegistro : ContentPage
{
	public vRegistro()
	{
		InitializeComponent();
	}

	private async void btnGuardar_Clicked(object? sender, EventArgs e)
	{
		try
		{
			string usuarioNuevo = txtUsuarioNuevo.Text;
			string contrasenaNueva = txtContrasenaNueva.Text;
			await Navigation.PushAsync(new vLogin(usuarioNuevo, contrasenaNueva));
			await DisplayAlertAsync("Alerta", "Usuario guardado", "Cerrar");
		}
		catch (Exception ex)
		{
			await DisplayAlertAsync("Error", ex.Message, "Cerrar");
		}
	}
}
