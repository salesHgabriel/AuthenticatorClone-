using Microsoft.Maui.Controls.Handlers.Compatibility;
using Microsoft.Maui.Controls.Platform.Compatibility;

namespace Clone.Microsoft.Authenticator.Platforms.Android
{
    class CustomShellHandler : ShellRenderer
    {
        protected override IShellBottomNavViewAppearanceTracker CreateBottomNavViewAppearanceTracker(ShellItem shellItem)
        {
            return new CustomShellBottomNavViewAppearanceTracker(this, shellItem.CurrentItem);
        }
    }
}
