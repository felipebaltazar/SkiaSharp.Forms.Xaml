using Skiasharp.Forms.Xaml.Exceptions;
using Xamarin.Forms;

namespace Skiasharp.Forms.Xaml
{
    public class Rectangle : PaintableDraw
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

        public static BindableProperty WidthProperty = BindableProperty.Create(
            propertyName: nameof(Width),
            returnType: typeof(float?),
            declaringType: typeof(Rectangle),
            defaultValue: null,
            propertyChanged: OnVisualPropertyChanged);

        public static BindableProperty HeightProperty = BindableProperty.Create(
            propertyName: nameof(Height),
            returnType: typeof(float?),
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

        public virtual float? Width
        {
            get => (float?)GetValue(WidthProperty);
            set => SetValue(WidthProperty, value);
        }
        public virtual float? Height
        {
            get => (float?)GetValue(HeightProperty);
            set => SetValue(HeightProperty, value);
        }

        protected override void DrawWithPaint(DrawContext drawContext)
        {
            EnsureParameters();
            drawContext.Canvas.DrawRect(X ?? 0, Y ?? 0, Width.Value, Height.Value, drawContext.Paint);
        }

        private void EnsureParameters()
        {
            if (!Width.HasValue)
                throw new InvalidDrawParameterException(nameof(Width));

            if (!Height.HasValue)
                throw new InvalidDrawParameterException(nameof(Height));
        }
    }
}
