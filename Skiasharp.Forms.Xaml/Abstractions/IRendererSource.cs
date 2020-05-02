using System.Collections.Generic;

namespace Skiasharp.Forms.Xaml.Abstractions
{
    public interface IRendererSource : IWithParentElement
    {
        IEnumerable<DrawElement> GetDraws();
    }
}
