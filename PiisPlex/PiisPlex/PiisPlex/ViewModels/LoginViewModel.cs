using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PiisPlex.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        public Action DisplayInvalidLoginPrompt;
        private string m_email;
        public string Email
        {
            get { return m_email; }
            set { m_email = value; PropertyChanged(this, new PropertyChangedEventArgs("Email")); }
        }

        private string m_password;
        public string Password
        {
            get { return m_password; }
            set { m_password = value; PropertyChanged(this, new PropertyChangedEventArgs("Password")); }
        }

        public ICommand SubmitCommand { protected set; get; }
        public LoginViewModel()
        {
            SubmitCommand = new Command(OnSubmit);
        }

        public void OnSubmit()
        {
            if (Email != "abc" || Password != "abc")
                DisplayInvalidLoginPrompt();
        }
    }
}
