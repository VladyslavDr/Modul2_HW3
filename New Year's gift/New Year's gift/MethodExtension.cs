using System;

namespace New_Year_s_gift
{
    public static class MethodExtension
    {
        public static void NameSearch(this Sweetness[] sweetnesses, string name)
        {
            foreach (var sweetness in sweetnesses)
            {
                if (sweetness != null && sweetness.Name.ToLower().Equals(name.ToLower()))
                {
                    Console.WriteLine($"\tname: {sweetness.Name} ");
                    Console.Write($"\tweight: {sweetness.Weight.Value}");
                    Console.WriteLine($"{sweetness.Weight.Measure}");
                    Console.Write($"\tcost: {sweetness.Price.Value}");
                    Console.WriteLine($"{sweetness.Price.Currency}");
                }
            }
        }

        public static void PriceSearh(this Sweetness[] sweetnesses, Price price)
        {
            foreach (var sweetness in sweetnesses)
            {
                if (sweetness != null && sweetness.Price.Value == price.Value)
                {
                    Console.WriteLine($"\tname: {sweetness.Name} ");
                    Console.Write($"\tweight: {sweetness.Weight.Value}");
                    Console.WriteLine($"{sweetness.Weight.Measure}");
                    Console.Write($"\tcost: {sweetness.Price.Value}");
                    Console.WriteLine($"{sweetness.Price.Currency}");
                }
            }
        }

        public static void WidthSearh(this Sweetness[] sweetnesses, Weight weight)
        {
            foreach (var sweetness in sweetnesses)
            {
                if (sweetness != null && sweetness.Weight.Value == weight.Value)
                {
                    Console.WriteLine($"\tname: {sweetness.Name} ");
                    Console.Write($"\tweight: {sweetness.Weight.Value}");
                    Console.WriteLine($"{sweetness.Weight.Measure}");
                    Console.Write($"\tcost: {sweetness.Price.Value}");
                    Console.WriteLine($"{sweetness.Price.Currency}");
                }
            }
        }
    }
}
