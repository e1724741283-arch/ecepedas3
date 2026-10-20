namespace ecepedas3.Views;

public partial class login : ContentPage
{
	string usuario=" ", contrasena="";
	public login()
	{
		InitializeComponent();
	}

	public login(string usuarioNuevo, string contrasenaNueva)
	{
		InitializeComponent();
		this.usuario = usuarioNuevo;
		this.contrasena = contrasenaNueva;
	}

    [Obsolete]
    private async void btnIniciarSesion_Clicked(object sender, EventArgs e)
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

	private async void btnRegister_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new registro());
	}
}