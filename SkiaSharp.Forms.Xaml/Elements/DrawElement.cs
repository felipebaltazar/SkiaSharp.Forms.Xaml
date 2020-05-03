using SkiaSharp.Views.Forms;
using Xamarin.Forms;

namespace SkiaSharp.Forms.Xaml
{
    public abstract class DrawElement : InvalidateObject
    {
        public static BindableProperty ColorProperty = BindableProperty.Create(
            propertyName: nameof(Color),
            returnType: typeof(Color),
            declaringType: typeof(DrawElement),
            defaultValue: Color.Transparent,
            propertyChanged: OnVisualPropertyChanged);

        public virtual Color Color
        {
            get => (Color)GetValue(ColorProperty);
            set => SetValue(ColorProperty, value);
        }

        public abstract void OnDrawSurface(object sender, SKPaintSurfaceEventArgs e);
    }
}
