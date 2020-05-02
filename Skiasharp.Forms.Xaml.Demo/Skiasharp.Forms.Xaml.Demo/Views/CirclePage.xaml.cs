
using Skiasharp.Forms.Xaml.Demo.ViewModels;
using Xamarin.Forms;

namespace Skiasharp.Forms.Xaml.Demo.Views
{
    public partial class CirclePage : ContentPage
    {
        public CirclePage()
        {
            InitializeComponent();
            BindingContext = new CirclePageViewModel();
        }
    }
}