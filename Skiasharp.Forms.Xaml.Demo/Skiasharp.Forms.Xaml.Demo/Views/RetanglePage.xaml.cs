
using Skiasharp.Forms.Xaml.Demo.ViewModels;
using Xamarin.Forms;

namespace Skiasharp.Forms.Xaml.Demo.Views
{
    public partial class RetanglePage : ContentPage
    {
        public RetanglePage()
        {
            InitializeComponent();
            BindingContext = new RetanglePageViewModel();
        }
    }
}