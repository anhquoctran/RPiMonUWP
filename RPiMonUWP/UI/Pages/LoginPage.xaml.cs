using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using RPiMonUWP.ObjectModels.ReferenceOjects;
using RPiMonUWP.ViewModels;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace RPiMonUWP.UI.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginPage : Page

    {

        private string _token = "";
        public LoginPage()
        {
            this.InitializeComponent();
        }

        private async void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Password == "")
            {
                await new MessageDialog("Don't leave blank required field!").ShowAsync();
                

            }
            else
            {
                var reslogin = await Login(txtUsername.Text, txtPassword.Password);
                if (reslogin != null)
                {
                    ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;
                    localSettings.Values["userdata"] = reslogin;
                    Frame.Navigate(typeof(MainPage));
                }
                else
                {

                    txtUsername.Text = txtPassword.Password = string.Empty;
                    await new MessageDialog("Username or password incorrect! Please try again!").ShowAsync();
                }
            }
            
        }

        private async Task<UserModels> Login(string username, string password)
        {
            UserModels res;
            UserManagementViewModel umvm = new UserManagementViewModel(_token);
            res = await umvm.Login(username, password);
            return res;
        }
    }
}
