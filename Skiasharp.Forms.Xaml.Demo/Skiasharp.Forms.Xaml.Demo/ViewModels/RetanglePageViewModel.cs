namespace Skiasharp.Forms.Xaml.Demo.ViewModels
{
    public class RetanglePageViewModel : BaseViewModel
    {
        private float positionX;
        private float positionY;
        private float height;
        private float width;
        private float strokeWidth;

        public float PositionX
        {
            get => positionX;
            set => SetProperty(ref positionX, value);
        }

        public float PositionY
        {
            get => positionY;
            set => SetProperty(ref positionY, value);
        }

        public float Width
        {
            get => width;
            set => SetProperty(ref width, value);
        }

        public float Height
        {
            get => height;
            set => SetProperty(ref height, value);
        }

        public float StrokeWidth
        {
            get => strokeWidth;
            set => SetProperty(ref strokeWidth, value);
        }

        public RetanglePageViewModel()
        {
            PositionX = 1000;
            PositionY = 1000;
            Width = 500;
            Height = 500;
            StrokeWidth = 25;
        }
    }
}
