using Skiasharp.Forms.Xaml.Demo.Helpers;

namespace Skiasharp.Forms.Xaml.Demo.ViewModels
{
    public abstract class BaseViewModel : ObservableObject
    {
        private bool isBusy = false;


        public bool IsBusy
        {
            get => isBusy;
            set => SetProperty(ref isBusy, value);
        }
    }
}
