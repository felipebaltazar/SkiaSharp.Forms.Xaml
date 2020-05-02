using SkiaSharp.Forms.Xaml.Abstractions;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;

namespace SkiaSharp.Forms.Xaml
{
    public abstract class DrawElement : BindableObject, IWithParentElement, IInvalidateElement
    {
        public static BindableProperty ColorProperty = BindableProperty.Create(
            propertyName: nameof(Color),
            returnType: typeof(Color),
            declaringType: typeof(Clear),
            defaultValue: Color.Transparent,
            propertyChanged: OnVisualPropertyChanged);

        public virtual Color Color
        {
            get => (Color)GetValue(ColorProperty);
            set => SetValue(ColorProperty, value);
        }

        public virtual SKCanvasView Parent { get; set; }

        public virtual void InvalidateSurface() => Parent?.InvalidateSurface();

        public abstract void OnDrawSurface(object sender, SKPaintSurfaceEventArgs e);

        protected static void OnVisualPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is DrawElement drawElement)
                drawElement.InvalidateSurface();
        }
    }
}
