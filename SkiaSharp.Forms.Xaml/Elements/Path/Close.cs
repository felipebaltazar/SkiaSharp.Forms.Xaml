namespace SkiaSharp.Forms.Xaml
{
    public class Close : PathElement
    {
        public override void ComposePath(SKPath path) => path.Close();
    }
}
