namespace ecepedas3.Views;

public partial class vLogin : ContentPage
{
	string usuario=" ", contrasena=" ";
	public vLogin()
	{
		InitializeComponent();
	}

	public vLogin(string usuarioNuevo, string contrasenaNueva)
	{
		InitializeComponent();
		this.usuario = usuarioNuevo;
		this.contrasena = contrasenaNueva;
	}

	private async void btnIniciarSesion_Clicked(object? sender, EventArgs e)
	{
		try
		{
			string usuarioIngreso = txtUsuario.Text;
			string contrasenaIngreso = txtContrasena.Text;
			if (usuarioIngreso == usuario && contrasenaIngreso == contrasena)
			{
				await Navigation.PushAsync(new vReporte(usuario));
			}
			else
			{
				await DisplayAlertAsync("Alerta", "Usuario o contraseña incorrectos", "OK");
			}
		}
		catch (Exception ex)
		{
			await DisplayAlertAsync("Error", ex.Message, "Cerrar");
		}
	}

	private async void btnRegistrar_Clicked(object? sender, EventArgs e)
	{
		await Navigation.PushAsync(new vRegistro());
	}
}
