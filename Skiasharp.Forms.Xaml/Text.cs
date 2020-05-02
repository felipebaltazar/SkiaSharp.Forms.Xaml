using Skiasharp.Forms.Xaml.Exceptions;
using Xamarin.Forms;

namespace Skiasharp.Forms.Xaml
{
    [ContentProperty(nameof(Source))]
    public class Text : PaintableDraw
    {
        public static BindableProperty XProperty = BindableProperty.Create(
           propertyName: nameof(X),
           returnType: typeof(float?),
           declaringType: typeof(Rectangle),
           defaultValue: null,
           propertyChanged: OnVisualPropertyChanged);

        public static BindableProperty YProperty = BindableProperty.Create(
            propertyName: nameof(Y),
            returnType: typeof(float?),
            declaringType: typeof(Rectangle),
            defaultValue: null,
            propertyChanged: OnVisualPropertyChanged);

        public static BindableProperty SourceProperty = BindableProperty.Create(
            propertyName: nameof(Source),
            returnType: typeof(string),
            declaringType: typeof(Rectangle),
            defaultValue: null,
            propertyChanged: OnVisualPropertyChanged);

        public virtual float? X
        {
            get => (float?)GetValue(XProperty);
            set => SetValue(XProperty, value);
        }

        public virtual float? Y
        {
            get => (float?)GetValue(YProperty);
            set => SetValue(YProperty, value);
        }

        public string Source
        {
            get => (string)GetValue(SourceProperty);
            set => SetValue(SourceProperty, value);
        }

        protected override void DrawWithPaint(DrawContext drawContext)
        {
            drawContext.Canvas.DrawText(Source, X ?? 0, Y ?? 0, drawContext.Paint);
        }
    }
}
