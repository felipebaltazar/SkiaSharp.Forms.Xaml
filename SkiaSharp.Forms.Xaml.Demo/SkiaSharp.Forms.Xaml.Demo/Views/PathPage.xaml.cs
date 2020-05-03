using SkiaSharp.Forms.Xaml.Demo.ViewModels;

using Xamarin.Forms;

namespace SkiaSharp.Forms.Xaml.Demo.Views
{
    public partial class PathPage : ContentPage
    {
        public PathPage()
        {
            InitializeComponent();
            BindingContext = new PathPageViewModel();
        }
    }
}