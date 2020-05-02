using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;

namespace Skiasharp.Forms.Xaml
{
    public abstract class PaintableDraw : DrawElement
    {
        public static BindableProperty IsAntialiasProperty = BindableProperty.Create(
            propertyName: nameof(IsAntialias),
            returnType: typeof(bool),
            declaringType: typeof(PaintableDraw),
            defaultValue: false,
            propertyChanged: OnVisualPropertyChanged);

        public static BindableProperty StyleProperty = BindableProperty.Create(
            propertyName: nameof(Style),
            returnType: typeof(SKPaintStyle),
            declaringType: typeof(PaintableDraw),
            defaultValue: SKPaintStyle.Fill,
            propertyChanged: OnVisualPropertyChanged);

        public static BindableProperty StrokeWidthProperty = BindableProperty.Create(
            propertyName: nameof(StrokeWidth),
            returnType: typeof(float),
            declaringType: typeof(PaintableDraw),
            defaultValue: 0f,
            propertyChanged: OnVisualPropertyChanged);

        public static BindableProperty TextSizeProperty = BindableProperty.Create(
            propertyName: nameof(TextSize),
            returnType: typeof(float),
            declaringType: typeof(PaintableDraw),
            defaultValue: 0f,
            propertyChanged: OnVisualPropertyChanged);

        public static BindableProperty TextAlignProperty = BindableProperty.Create(
            propertyName: nameof(TextAlign),
            returnType: typeof(SKTextAlign),
            declaringType: typeof(PaintableDraw),
            defaultValue: SKTextAlign.Center,
            propertyChanged: OnVisualPropertyChanged);


        public virtual bool IsAntialias
        {
            get => (bool)GetValue(IsAntialiasProperty);
            set => SetValue(IsAntialiasProperty, value);
        }

        public virtual SKPaintStyle Style
        {
            get => (SKPaintStyle)GetValue(StyleProperty);
            set => SetValue(StyleProperty, value);
        }

        public virtual float StrokeWidth 
        {
            get => (float)GetValue(StrokeWidthProperty);
            set => SetValue(StrokeWidthProperty, value);
        }

        public virtual float TextSize
        {
            get => (float)GetValue(TextSizeProperty);
            set => SetValue(TextSizeProperty, value);
        }

        public virtual SKTextAlign TextAlign
        {
            get => (SKTextAlign)GetValue(TextAlignProperty);
            set => SetValue(TextAlignProperty, value);
        }

        public override void OnDrawSurface(object sender, SKPaintSurfaceEventArgs e)
        {
            var surface = e.Surface;
            var canvas = surface.Canvas;
            var info = e.Info;

            using (var paint = new SKPaint()
            {
                IsAntialias = IsAntialias,
                Color = Color.ToSKColor(),
                Style = Style,
                StrokeWidth = StrokeWidth,
                TextSize = TextSize,
                TextAlign = TextAlign
            })
            {
                DrawWithPaint(new DrawContext(info, canvas, paint));
            }
        }

        protected abstract void DrawWithPaint(DrawContext drawContext);
    }
}
