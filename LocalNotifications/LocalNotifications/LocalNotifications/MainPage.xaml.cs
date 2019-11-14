using Plugin.LocalNotifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LocalNotifications
{
    /*
     * Link del Articulo 
     * https://xamarinlatino.com/local-notifications-en-xamarin-forms-4d213092d0c
     * 
     * Link del Repo
     * https://github.com/codercampos/XF-localnotifications
     * 
     * Link del nuget
     * https://www.nuget.org/packages/Xam.Plugins.Notifier
     * 
     */

    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnButton_Clicked(object sender, EventArgs e)
        {
            CrossLocalNotifications.Current.Show("Xamarin App", "Es una notificación", DateTime.Now.Millisecond, DateTime.Now.AddSeconds(2));
        }
    }
}
