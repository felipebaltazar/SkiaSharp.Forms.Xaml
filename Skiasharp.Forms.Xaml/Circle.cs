using Skiasharp.Forms.Xaml.Exceptions;
using Xamarin.Forms;

namespace Skiasharp.Forms.Xaml
{
    public class Circle : PaintableDraw
    {
        public static BindableProperty CenterXProperty = BindableProperty.Create(
            propertyName: nameof(CenterX),
            returnType: typeof(float?),
            declaringType: typeof(Circle),
            defaultValue: null,
            propertyChanged: OnVisualPropertyChanged);

        public static BindableProperty CenterYProperty = BindableProperty.Create(
            propertyName: nameof(CenterY),
            returnType: typeof(float?),
            declaringType: typeof(Circle),
            defaultValue: null,
            propertyChanged: OnVisualPropertyChanged);

        public static BindableProperty RadiusProperty = BindableProperty.Create(
            propertyName: nameof(Radius),
            returnType: typeof(float?),
            declaringType: typeof(Circle),
            defaultValue: null,
            propertyChanged: OnVisualPropertyChanged);

        public virtual float? CenterX
        {
            get => (float?)GetValue(CenterXProperty);
            set => SetValue(CenterXProperty, value);
        }

        public virtual float? CenterY
        {
            get => (float?)GetValue(CenterYProperty);
            set => SetValue(CenterYProperty, value);
        }

        public virtual float? Radius
        {
            get => (float?)GetValue(RadiusProperty);
            set => SetValue(RadiusProperty, value);
        }

        protected override void DrawWithPaint(DrawContext drawContext)
        {
            EnsureParameters();
            drawContext.Canvas.DrawCircle(CenterX.Value, CenterY.Value, Radius.Value, drawContext.Paint);
        }

        private void EnsureParameters()
        {
            if (!CenterX.HasValue)
                throw new InvalidDrawParameterException(nameof(CenterX));

            if (!CenterY.HasValue)
                throw new InvalidDrawParameterException(nameof(CenterY));

            if (!Radius.HasValue)
                throw new InvalidDrawParameterException(nameof(Radius));
        }
    }
}
