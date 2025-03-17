using ChalkeeDesktop.Model;

namespace ChalkeeDesktop.ViewModel
{
    class InfoVM : Utilities.ViewModelBase
    {
        private readonly PageModel _pageModel;

        public InfoVM()
        {
            _pageModel = new PageModel();
        }
    }
}
