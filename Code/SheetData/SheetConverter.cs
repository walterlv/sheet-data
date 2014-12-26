namespace Walterlv.Data.Sheeting
{
    public class SheetConverter
    {
        public SheetSource Source { get; private set; }

        public SheetConverter(SheetSource source)
        {
            Source = source;
        }
    }
}