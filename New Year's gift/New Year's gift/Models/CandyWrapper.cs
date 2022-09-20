using System;

namespace New_Year_s_gift
{
    public class CandyWrapper
    {
        public CandyWrapper(Material material, ConsoleColor color)
        {
            Material = material;
            Color = color;
        }

        public Material Material { get; init; }
        public ConsoleColor Color { get; init; }
    }
}
