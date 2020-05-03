using System.Collections.Generic;

namespace SkiaSharp.Forms.Xaml
{
    public class DrawElements<TElement> : BindableCollection<TElement> where TElement : DrawElement
    {
        public DrawElements()
        {
        }

        public DrawElements(IEnumerable<TElement> collection) : base(collection)
        {
        }

        public DrawElements(List<TElement> list) : base(list)
        {
        }
    }
}
