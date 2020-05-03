using SkiaSharp.Forms.Xaml.Exceptions;
using Xamarin.Forms;

namespace SkiaSharp.Forms.Xaml
{
    public class ArcTo : MoveTo
    {
        public static BindableProperty RadiusProperty = BindableProperty.Create(
          propertyName: nameof(Radius),
          returnType: typeof(float?),
          declaringType: typeof(ArcTo),
          defaultValue: null,
          propertyChanged: OnVisualPropertyChanged);

        public static BindableProperty RadiusXProperty = BindableProperty.Create(
           propertyName: nameof(RadiusX),
           returnType: typeof(float?),
           declaringType: typeof(ArcTo),
           defaultValue: null,
           propertyChanged: OnVisualPropertyChanged);

        public static BindableProperty RadiusYProperty = BindableProperty.Create(
            propertyName: nameof(RadiusY),
            returnType: typeof(float?),
            declaringType: typeof(ArcTo),
            defaultValue: null,
            propertyChanged: OnVisualPropertyChanged);

        public static BindableProperty AxisRotateXProperty = BindableProperty.Create(
            propertyName: nameof(AxisRotateX),
            returnType: typeof(float?),
            declaringType: typeof(ArcTo),
            defaultValue: null,
            propertyChanged: OnVisualPropertyChanged);

        public static BindableProperty ArchSizeProperty = BindableProperty.Create(
            propertyName: nameof(ArchSize),
            returnType: typeof(SKPathArcSize),
            declaringType: typeof(ArcTo),
            defaultValue: SKPathArcSize.Large,
            propertyChanged: OnVisualPropertyChanged);

        public static BindableProperty DirectionProperty = BindableProperty.Create(
            propertyName: nameof(Direction),
            returnType: typeof(SKPathDirection),
            declaringType: typeof(ArcTo),
            defaultValue: SKPathDirection.Clockwise,
            propertyChanged: OnVisualPropertyChanged);

        public virtual float? Radius
        {
            get => (float?)GetValue(RadiusProperty);
            set => SetValue(RadiusProperty, value);
        }

        public virtual float? RadiusX
        {
            get => (float?)GetValue(RadiusXProperty);
            set => SetValue(RadiusXProperty, value);
        }

        public virtual float? RadiusY
        {
            get => (float?)GetValue(RadiusYProperty);
            set => SetValue(RadiusYProperty, value);
        }

        public virtual float? AxisRotateX
        {
            get => (float?)GetValue(AxisRotateXProperty);
            set => SetValue(AxisRotateXProperty, value);
        }

        public virtual SKPathArcSize ArchSize
        {
            get => (SKPathArcSize)GetValue(ArchSizeProperty);
            set => SetValue(ArchSizeProperty, value);
        }

        public virtual SKPathDirection Direction
        {
            get => (SKPathDirection)GetValue(DirectionProperty);
            set => SetValue(DirectionProperty, value);
        }

        public override void ComposePath(SKPath path)
        {
            EnsureParameters();
            path.ArcTo(
                RadiusX ?? Radius.Value,
                RadiusY ?? Radius.Value,
                AxisRotateX ?? 0,
                ArchSize,
                Direction,
                X ?? 0,
                Y ?? 0);
        }

        protected virtual void EnsureParameters()
        {
            if (!RadiusX.HasValue && !Radius.HasValue)
                throw new InvalidDrawParameterException(nameof(RadiusX));

            if (!RadiusY.HasValue && !Radius.HasValue)
                throw new InvalidDrawParameterException(nameof(RadiusY));
        }
    }
}
