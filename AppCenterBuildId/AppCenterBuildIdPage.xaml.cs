using Xamarin.Forms;

namespace AppCenterBuildId
{
    public partial class AppCenterBuildIdPage : ContentPage
    {
        public TestViewModel ViewModel
        {
            get;
            set;
        }
        public AppCenterBuildIdPage()
        {
            InitializeComponent();
            BindingContext = ViewModel = new TestViewModel();
        }
    }
}
