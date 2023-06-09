namespace Clone.Microsoft.Authenticator;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
    }

    private void tabBarApp_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        var listener = sender as TabBar;

        int indexCurrentItem = listener.Items.IndexOf(listener.CurrentItem);

        for (var index = 0; index < listener.Items.Count; index++)
        {
            string title = listener.Items[index].Title;

            string iconName = GetIconByTitle(title);

            if (index == indexCurrentItem && listener.IsEnabled && title != "IDs Verificados")
            {
                listener.Items[indexCurrentItem].Icon = $"{iconName}_selected.png";

                continue;
            }

            listener.Items[index].Icon = $"{iconName}.png";
        }
    }

    private static string GetIconByTitle(string tilePage)
    {
        return tilePage switch
        {
            "Senhas" => "chave_inteligente",
            "Endereços" => "pointer",
            "Pagamentos" => "credit_card",
            "IDs Verificados" => "big_id_card",
            _ => "botao_home",
        };
    }
}