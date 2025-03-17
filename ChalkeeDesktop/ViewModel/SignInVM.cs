using System.Windows.Input;
using ChalkeeDesktop.Model;
using ChalkeeDesktop.Utilities;

namespace ChalkeeDesktop.ViewModel
{
    class SignInVM : Utilities.ViewModelBase
    {
        private string _username;
        public string Username
        {
            get => _username;
            set { _username = value; OnPropertyChanged(); }
        }

        private string _password;
        public string Password
        {
            get => _password;
            set { _password = value; OnPropertyChanged(); }
        }

        public ICommand AuthenticateCommand { get; }

        public SignInVM()
        {
            AuthenticateCommand = new RelayCommand(Authenticate);
        }

        private void Authenticate(object obj)
        {
            if (Username == "admin" && Password == "password")
            {
                if (App.Current.MainWindow.DataContext is NavigationVM navVM)
                {
                    navVM.IsAuthenticated = true;
                    navVM.CurrentView = new DashboardVM();
                }
            }
        }
    }
}