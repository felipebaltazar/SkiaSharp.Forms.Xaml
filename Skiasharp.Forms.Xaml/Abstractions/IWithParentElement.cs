using SkiaSharp.Views.Forms;

namespace Skiasharp.Forms.Xaml.Abstractions
{
    public interface IWithParentElement
    {
        SKCanvasView Parent { get; set; }
    }
}
