using SkiaSharp.Forms.Xaml.Abstractions;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;

namespace SkiaSharp.Forms.Xaml
{
    [ContentProperty(nameof(Source))]
    public class Path : PaintableDraw, IWithParentElement
    {
        private SKCanvasView _parent;
        private PathElements<PathElement> source;

        public override SKCanvasView Parent
        {
            get => _parent;
            set
            {
                if (_parent == value)
                    return;

                Source?.Release();
                _parent = value;
                Source?.AttachTo(_parent);
            }
        }

        public PathElements<PathElement> Source
        {
            get => source;
            set
            {
                if (source == value)
                    return;

                source?.Release();
                source = value;
                source?.AttachTo(_parent);
            }
        }

        public Path()
        {
            Source = new PathElements<PathElement>();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            source?.AttachTo(_parent);
        }

        protected override void DrawWithPaint(DrawContext drawContext)
        {
            using (var path = new SKPath())
            {
                foreach (var pathElement in Source)
                    pathElement.ComposePath(path);

                drawContext.Canvas.DrawPath(path, drawContext.Paint);
            }
        }
    }
}
