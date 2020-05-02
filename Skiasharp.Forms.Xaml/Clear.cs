using SkiaSharp.Views.Forms;
using Xamarin.Forms;

namespace Skiasharp.Forms.Xaml
{
    public class Clear : DrawElement
    {
        public override void OnDrawSurface(object sender, SKPaintSurfaceEventArgs e)
        {
            var surface = e.Surface;
            var canvas = surface.Canvas;

            if (Color == Color.Transparent)
                canvas.Clear();
            else
                canvas.Clear(Color.ToSKColor());
        }
    }
}
