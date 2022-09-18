using System;

namespace New_Year_s_gift
{
    public abstract class Marmalade : SugarProduct
    {
        public FlavorAdditive FlavorAdditive { get; set; }
        public Thickener Thickener { get; set; }
        public ConsoleColor Color { get; set; }
    }
}
