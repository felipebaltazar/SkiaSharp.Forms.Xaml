using SkiaSharp.Forms.Xaml.Abstractions;
using System.Collections.Generic;

namespace SkiaSharp.Forms.Xaml
{
    public class PathElements<TElement> : BindableCollection<TElement>
        where TElement : PathElement, IWithParentElement
    {
        public PathElements()
        {
        }

        public PathElements(IEnumerable<TElement> collection) : base(collection)
        {
        }

        public PathElements(List<TElement> list) : base(list)
        {
        }
    }
}
