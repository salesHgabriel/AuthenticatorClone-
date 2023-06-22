using Clone.Microsoft.Authenticator.Models;

namespace Clone.Microsoft.Authenticator.Views;

public partial class AuthenticatorPage : ContentPage
{
	public List<Conta> ListaContas = new List<Conta>()
	{
		new Conta("Empresa X" , "fulano@x.com"),
		new Conta("Empresa Y" , "fulano@y.com"),
		new Conta("Empresa Z" , "fulano@z.com"),
		new Conta("Empresa A" , "fulano@a.com"),
    };

	public AuthenticatorPage()
	{
		InitializeComponent();
		BindingContext = ListaContas;
		ListaContasCollectionView.ItemsSource = ListaContas;
	}

    private async void ToolbarItem_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(NovaContaPage));
    }
}