using Lottie.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace Rollandplay
{
    public partial class AppShell : Xamarin.Forms.TabbedPage
    {
        public AppShell()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            Shell.SetTabBarIsVisible(this, true);
            On<Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);

        }
    }
}