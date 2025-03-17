using ChalkeeDesktop.Utilities;
using System.Windows.Input;
using ChalkeeDesktop.View;

namespace ChalkeeDesktop.ViewModel
{
    class NavigationVM : ViewModelBase
    {
        private bool _isAuthenticated;
        public bool IsAuthenticated
        {
            get => _isAuthenticated;
            set { _isAuthenticated = value; OnPropertyChanged(); }
        }

        private object _currentView;
        public object CurrentView
        {
            get => _currentView;
            set { _currentView = value; OnPropertyChanged(); }
        }

        public ICommand DashboardCommand { get; set; }
        public ICommand TimetableCommand { get; set; }
        public ICommand InfoCommand { get; set; }
        public ICommand SignInCommand { get; set; }
        public ICommand AuthenticateCommand { get; set; }

        private void Dashboard(object obj) 
        {
            if (IsAuthenticated) CurrentView = new DashboardVM();
        }

        private void Timetable(object obj) 
        {
            if (IsAuthenticated) CurrentView = new TimetableVM();
        }

        private void Info(object obj) 
        {
            if (IsAuthenticated) CurrentView = new InfoVM();
        }

        private void SignIn(object obj) => CurrentView = new SignIn();

        private void UpdateView()
        {
            if (!IsAuthenticated)
                CurrentView = new SignIn();
            else
                CurrentView = new DashboardVM();
        }

        public NavigationVM()
        {
            DashboardCommand = new RelayCommand(Dashboard);
            TimetableCommand = new RelayCommand(Timetable);
            InfoCommand = new RelayCommand(Info);
            SignInCommand = new RelayCommand(SignIn);

            IsAuthenticated = false;
            CurrentView = new SignIn();
        }
    }
}
