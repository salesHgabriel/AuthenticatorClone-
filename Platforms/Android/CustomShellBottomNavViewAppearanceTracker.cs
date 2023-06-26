using Android.Text.Style;
using Android.Text;
using Android.Views;
using Google.Android.Material.BottomNavigation;
using Microsoft.Maui.Controls.Platform.Compatibility;
using Android.Graphics.Drawables;

namespace Clone.Microsoft.Authenticator.Platforms.Android
{
    class CustomShellBottomNavViewAppearanceTracker : ShellBottomNavViewAppearanceTracker
    {
        public CustomShellBottomNavViewAppearanceTracker(IShellContext shellContext, ShellItem shellItem) : base(shellContext, shellItem)
        {
        }


        public override void SetAppearance(BottomNavigationView bottomView, IShellAppearanceElement appearance)
        {
            IMenu menu = bottomView.Menu;

            for (int i = 0; i < bottomView.Menu.Size(); i++)
            {

                UpdateIconTab(menu, i);
            }

            base.SetAppearance(bottomView, appearance);
        }

        private static void UpdateIconTab(IMenu menu, int i)
        {
            IMenuItem menuItem = menu.GetItem(i);

            var resourceIdIcon = GetResourceIconByPositionAndChecked(i, menuItem.IsChecked);
            
            menuItem.SetIcon(resourceIdIcon);
        }

        private static int GetResourceIconByPositionAndChecked(int position, bool isChecked)
        {

            var listIconSelected = new int[]
            {
                Resource.Drawable.botao_home_selected,
                Resource.Drawable.chave_inteligente_selected,
                Resource.Drawable.credit_card_selected,
                Resource.Drawable.pointer_selected,
                Resource.Drawable.big_id_card,
            };

            var listIcon = new int[]
            {
                Resource.Drawable.botao_home,
                Resource.Drawable.chave_inteligente,
                Resource.Drawable.credit_card,
                Resource.Drawable.pointer,
                Resource.Drawable.big_id_card,
            };


            if (isChecked)
            {
                return listIconSelected[position];
            }

            return listIcon[position];

        }



    }
}
