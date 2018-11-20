using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Globalization;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PartnerTestbed
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void ButtonBase_OnClickEN(object sender, RoutedEventArgs e)
        {
            ApplicationLanguages.PrimaryLanguageOverride = "en-US";
            Windows.ApplicationModel.Resources.Core.ResourceContext.GetForCurrentView().Reset();
            Windows.ApplicationModel.Resources.Core.ResourceContext.GetForViewIndependentUse().Reset();
            await Task.Delay(100);
            Frame.Navigate(this.GetType());
        }

        private async void ButtonBase_OnClickDE(object sender, RoutedEventArgs e)
        {
            ApplicationLanguages.PrimaryLanguageOverride = "de";
            Windows.ApplicationModel.Resources.Core.ResourceContext.GetForCurrentView().Reset();
            Windows.ApplicationModel.Resources.Core.ResourceContext.GetForViewIndependentUse().Reset();
            await Task.Delay(100);
            Frame.Navigate(this.GetType());
        }
    }
}
