using Skiasharp.Forms.Xaml.Abstractions;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;

namespace Skiasharp.Forms.Xaml
{
    public static class DrawSurface
    {
        public static readonly BindableProperty RendererProperty = BindableProperty.CreateAttached(
            propertyName: "Renderer",
            returnType: typeof(IRendererSource),
            declaringType: typeof(SKCanvasView),
            defaultValue: null,
            propertyChanged: OnRendererChanged);

        public static void SetRenderer(BindableObject b, IRendererSource value) =>
            b.SetValue(RendererProperty, value);

        public static IRendererSource GetRenderer(BindableObject b) =>
            (IRendererSource)b.GetValue(RendererProperty);

        private static void OnRendererChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var skCanvasView = ((SKCanvasView)bindable);
            SubscribeEvents(skCanvasView);

            if (oldValue != null)
                ((IRendererSource)oldValue).Parent = null;

            if (newValue != null)
                ((IRendererSource)newValue).Parent = skCanvasView;

            skCanvasView.InvalidateSurface();
        }

        private static void SubscribeEvents(SKCanvasView skCanvasView)
        {
            skCanvasView.PaintSurface -= OnPaintSurface;
            skCanvasView.PaintSurface += OnPaintSurface;

            skCanvasView.BindingContextChanged += OnBindingContextChanged;
        }

        private static void OnBindingContextChanged(object sender, System.EventArgs e)
        {
            var skCanvasView = (SKCanvasView)sender;
            var rendererSource = GetRenderer(skCanvasView);

            if (rendererSource is BindableObject bindable)
                BindableObject.SetInheritedBindingContext(bindable, skCanvasView.BindingContext);
        }

        private static void OnPaintSurface(object sender, SKPaintSurfaceEventArgs e)
        {
            var skCanvasView = (SKCanvasView)sender;
            var rendererSource = GetRenderer(skCanvasView);
            var draws = rendererSource.GetDraws();

            foreach (var draw in draws)
                draw.OnDrawSurface(sender, e);
        }
    }
}
