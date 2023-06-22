using Clone.Microsoft.Authenticator.Views;

namespace Clone.Microsoft.Authenticator;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        RegisterRoutesApp();
    }

    private void RegisterRoutesApp()
    {
        Routing.RegisterRoute(nameof(NovaContaPage), typeof(NovaContaPage));
    }
}