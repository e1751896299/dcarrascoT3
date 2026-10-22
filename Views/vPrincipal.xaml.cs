namespace dcarrascoT3.Views;

public partial class vPrincipal : ContentPage
{
	public vPrincipal(string usuario)
	{
		InitializeComponent();

		DisplayAlertAsync("Bienvenido", usuario, "Cerrar");
		lbUsuario.Text = "Usuario Conectado" + usuario;
	}
}