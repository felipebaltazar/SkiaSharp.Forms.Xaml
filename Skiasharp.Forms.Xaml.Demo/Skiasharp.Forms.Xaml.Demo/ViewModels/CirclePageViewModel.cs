namespace Skiasharp.Forms.Xaml.Demo.ViewModels
{
    public class CirclePageViewModel : BaseViewModel
    {
        private float positionX;
        private float positionY;
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

        public float Radius
        {
            get => width;
            set => SetProperty(ref width, value);
        }


        public float StrokeWidth
        {
            get => strokeWidth;
            set => SetProperty(ref strokeWidth, value);
        }

        public CirclePageViewModel()
        {
            PositionX = 1000;
            PositionY = 1000;
            Radius = 150;
            StrokeWidth = 25;
        }
    }
}
