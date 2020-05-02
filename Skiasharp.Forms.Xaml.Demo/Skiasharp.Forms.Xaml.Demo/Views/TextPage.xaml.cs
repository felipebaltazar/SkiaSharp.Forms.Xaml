using Skiasharp.Forms.Xaml.Demo.ViewModels;

using Xamarin.Forms;

namespace Skiasharp.Forms.Xaml.Demo.Views
{
    public partial class TextPage : ContentPage
    {
        public TextPage()
        {
            InitializeComponent();
            BindingContext = new TextPageViewModel();
        }
    }
}