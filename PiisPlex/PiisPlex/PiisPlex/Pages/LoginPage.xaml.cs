using PiisPlex.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PiisPlex.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            LoginViewModel loginView = new LoginViewModel();
            this.BindingContext = loginView;
            loginView.DisplayInvalidLoginPrompt += () => DisplayAlert("Error", "Invalid Login, try again", "OK");
            InitializeComponent();

            Email.Completed += (object sender, EventArgs e) => Password.Focus();
            Password.Completed += (object sender, EventArgs e) => loginView.SubmitCommand.Execute(null);
        }        
    }
}