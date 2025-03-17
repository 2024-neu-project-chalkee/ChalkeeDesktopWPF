using ChalkeeDesktop.Model;

namespace ChalkeeDesktop.ViewModel
{
    class TimetableVM : Utilities.ViewModelBase
    {
        private readonly PageModel _pageModel;

        public TimetableVM()
        {
            _pageModel = new PageModel();
        }
    }
}