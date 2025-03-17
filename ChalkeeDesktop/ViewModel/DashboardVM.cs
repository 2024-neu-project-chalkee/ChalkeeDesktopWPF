using ChalkeeDesktop.Model;

namespace ChalkeeDesktop.ViewModel
{
    class DashboardVM : Utilities.ViewModelBase
    {
        private readonly PageModel _pageModel;

        public DashboardVM()
        {
            _pageModel = new PageModel();
        }
    }
}
