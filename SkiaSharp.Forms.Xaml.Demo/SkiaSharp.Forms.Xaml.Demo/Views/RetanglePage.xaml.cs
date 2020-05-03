
using SkiaSharp.Forms.Xaml.Demo.ViewModels;
using Xamarin.Forms;

namespace SkiaSharp.Forms.Xaml.Demo.Views
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