
using SkiaSharp.Forms.Xaml.Demo.ViewModels;
using Xamarin.Forms;

namespace SkiaSharp.Forms.Xaml.Demo.Views
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