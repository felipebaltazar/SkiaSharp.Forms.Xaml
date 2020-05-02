using Skiasharp.Forms.Xaml.Abstractions;
using SkiaSharp.Views.Forms;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Skiasharp.Forms.Xaml
{
    [ContentProperty(nameof(Source))]
    public class RendererSource : BindableObject, IRendererSource
    {
        private SKCanvasView _parent;
        private DrawElements<DrawElement> source;

        public SKCanvasView Parent
        {
            get => _parent;
            set
            {
                if (_parent == value)
                    return;

                Source?.Release();
                _parent = value;
                Source?.AttachTo(_parent);
            }
        }
        
        public DrawElements<DrawElement> Source 
        { 
            get => source;
            set
            {
                if (source == value)
                    return;

                source?.Release();
                source = value;
                source?.AttachTo(_parent);
            }
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            source?.AttachTo(_parent);
        }

        public RendererSource() =>
            Source = new DrawElements<DrawElement>();

        public IEnumerable<DrawElement> GetDraws() => Source;
    }
}
