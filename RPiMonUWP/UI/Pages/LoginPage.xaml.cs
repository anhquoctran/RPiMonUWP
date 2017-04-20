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
using Windows.Security.Credentials;
using RPiMonUWP.Commons;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace RPiMonUWP.UI.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginPage : Page

    {
        public static PasswordVault _Locker = new PasswordVault();
        PasswordCredential _credential = new PasswordCredential();

        private string _token = "";
        public LoginPage()
        {
            this.InitializeComponent();
            _credential.RetrievePassword();
            if (_credential.UserName != "" || _credential.Password != "")
            {
                
            }
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
                    _credential.Resource = "Login";
                    _credential.Password = txtPassword.Password;
                    _credential.UserName = txtUsername.Text;
                    if (ChkRemember.IsChecked.Value == true)
                    {
                        
                    }
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

        private void LinkForgot_Click(Windows.UI.Xaml.Documents.Hyperlink sender, Windows.UI.Xaml.Documents.HyperlinkClickEventArgs args)
        {
            Frame.Navigate(typeof(ForgotPage));
        }
    }
}
