using System.Collections.Generic;

namespace SkiaSharp.Forms.Xaml.Abstractions
{
    public interface IRendererSource : IWithParentElement
    {
        IEnumerable<DrawElement> GetDraws();
    }
}
