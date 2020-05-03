using SkiaSharp.Forms.Xaml.Demo.ViewModels;

using Xamarin.Forms;

namespace SkiaSharp.Forms.Xaml.Demo.Views
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