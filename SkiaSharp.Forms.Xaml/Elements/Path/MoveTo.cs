using Xamarin.Forms;

namespace SkiaSharp.Forms.Xaml
{
    public class MoveTo : PathElement
    {
        public static BindableProperty XProperty = BindableProperty.Create(
           propertyName: nameof(X),
           returnType: typeof(float?),
           declaringType: typeof(MoveTo),
           defaultValue: null,
           propertyChanged: OnVisualPropertyChanged);

        public static BindableProperty YProperty = BindableProperty.Create(
            propertyName: nameof(Y),
            returnType: typeof(float?),
            declaringType: typeof(MoveTo),
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

        public override void ComposePath(SKPath path) =>
            path.MoveTo(X ?? 0, Y ?? 0);
    }
}
