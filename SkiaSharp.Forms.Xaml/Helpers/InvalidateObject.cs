using SkiaSharp.Forms.Xaml.Abstractions;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;

namespace SkiaSharp.Forms.Xaml
{
    public abstract class InvalidateObject : BindableObject, IWithParentElement, IInvalidateElement
    {
        public virtual SKCanvasView Parent { get; set; }

        public virtual void InvalidateSurface() => Parent?.InvalidateSurface();

        protected static void OnVisualPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is IInvalidateElement invalidateObject)
                invalidateObject.InvalidateSurface();
        }
    }
}
