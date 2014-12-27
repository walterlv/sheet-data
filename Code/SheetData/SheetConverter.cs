using System;

namespace Walterlv.Data.Sheeting
{
    public class SheetConverter
    {
        public SheetSource Source { get; private set; }

        public SheetConverter(SheetSource source)
        {
            if (source == null) throw new ArgumentNullException("source");
            Source = source;
        }
    }
}
