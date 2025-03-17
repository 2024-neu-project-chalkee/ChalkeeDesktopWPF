using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ChalkeeDesktop.Utilities
{
    class ViewModelBase : INotifyPropertyChanged
    {
        private bool _isAuthenticated;

        public bool IsAuthenticated
        {
            get { return _isAuthenticated; }
            set
            {
                _isAuthenticated = value;
                OnPropertyChanged();
            }
        }

        public ViewModelBase()
        {
            IsAuthenticated = false;
        }

        public void SignIn(string username, string password)
        {
            if (username == "admin" && password == "password")
            {
                IsAuthenticated = true;
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
