namespace SkiaSharp.Forms.Xaml.Demo.ViewModels
{
    public sealed class PathPageViewModel : BaseViewModel
    {

        private float startX;
        private float startY;
        private float lineX;
        private float lineY;
        private float arcX;
        private float arcY;
        private float arcRadius;

        public float StartX
        {
            get => startX;
            set => SetProperty(ref startX, value);
        }

        public float StartY
        {
            get => startY;
            set => SetProperty(ref startY, value);
        }

        public float LineX
        {
            get => lineX;
            set => SetProperty(ref lineX, value);
        }

        public float LineY
        {
            get => lineY;
            set => SetProperty(ref lineY, value);
        }

        public float ArcX
        {
            get => arcX;
            set => SetProperty(ref arcX, value);
        }
        public float ArcY
        {
            get => arcY;
            set => SetProperty(ref arcY, value);
        }

        public float ArcRadius
        {
            get => arcRadius;
            set => SetProperty(ref arcRadius, value);
        }

        public PathPageViewModel()
        {
            StartX = 800;
            StartY = 320;
            LineX = 1200;
            LineY = 300;
            ArcX = 250;
            ArcY = 500;
            ArcRadius = 150;
        }
    }
}
