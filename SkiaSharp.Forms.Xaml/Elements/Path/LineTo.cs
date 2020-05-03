namespace SkiaSharp.Forms.Xaml
{
    public class LineTo : MoveTo
    {
        public override void ComposePath(SKPath path) =>
            path.LineTo(X ?? 0, Y ?? 0);
    }
}
