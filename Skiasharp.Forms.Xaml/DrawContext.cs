using SkiaSharp;

namespace SkiaSharp.Forms.Xaml
{
    public struct DrawContext
    {
        public SKImageInfo Info { get; private set; }
        public SKCanvas Canvas { get; private set; }
        public SKPaint Paint { get; private set; }

        public DrawContext(SKImageInfo info, SKCanvas canvas, SKPaint paint)
        {
            Info = info;
            Canvas = canvas;
            Paint = paint;
        }
    }
}
