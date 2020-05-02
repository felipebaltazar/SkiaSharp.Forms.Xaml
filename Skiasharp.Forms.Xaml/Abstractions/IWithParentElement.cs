using SkiaSharp.Views.Forms;

namespace SkiaSharp.Forms.Xaml.Abstractions
{
    public interface IWithParentElement
    {
        SKCanvasView Parent { get; set; }
    }
}
