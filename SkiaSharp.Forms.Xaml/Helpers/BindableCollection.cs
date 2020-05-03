using SkiaSharp.Forms.Xaml.Abstractions;
using SkiaSharp.Views.Forms;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using Xamarin.Forms;

namespace SkiaSharp.Forms.Xaml
{
    public abstract class BindableCollection<TElement> : ObservableCollection<TElement>
        where TElement : BindableObject, IWithParentElement
    {
        public SKCanvasView Parent { get; set; }

        protected BindableCollection() { }

        protected BindableCollection(IEnumerable<TElement> collection) : base(collection) { }

        protected BindableCollection(List<TElement> list) : base(list) { }

        protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
        {
            base.OnCollectionChanged(e);

            if (Parent == null)
                return;

            var isChanged = false;

            if (e.OldItems != null)
            {
                SetupItems(e.OldItems, null);
                isChanged = true;
            }

            if (e.NewItems != null)
            {
                SetupItems(e.NewItems, Parent);
                isChanged = true;
            }

            if (isChanged)
            {
                Parent.InvalidateSurface();
            }
        }

        private void SetupItems(IList items, SKCanvasView parent)
        {
            foreach (var item in items)
            {
                var element = (TElement)item;
                BindableObject.SetInheritedBindingContext(element, parent?.BindingContext);
                element.Parent = parent;
            }
        }

        internal void AttachTo(SKCanvasView parent)
        {
            Parent = parent;

            foreach (var item in Items)
            {
                BindableObject.SetInheritedBindingContext(item, Parent?.BindingContext);
                item.Parent = parent;
            }

            Parent?.InvalidateSurface();
        }

        internal void Release()
        {
            Parent = null;

            foreach (var item in Items)
            {
                BindableObject.SetInheritedBindingContext(item, null);
                item.Parent = null;
            }
        }

        internal void SetInheritedBindingContext(object bindingContext)
        {
            foreach (var item in Items)
            {
                BindableObject.SetInheritedBindingContext(item, bindingContext);
            }
        }
    }
}
