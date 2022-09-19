﻿using System;

namespace New_Year_s_gift
{
    public class Gift : ITemplateGift
    {
        private Sweetness[] _sweetnesses;
        private int _counter;

        public Gift()
        {
            _sweetnesses = new Sweetness[10];
        }

        public Weight TotalWeight()
        {
            double current = 0;

            for (int index = 0; index < _counter; index++)
            {
                current += _sweetnesses[index].Weight.Value;
            }

            return new Weight(value: current / 1000, measure: Measure.Kg);
        }

        public void AddItem(Sweetness sweetness)
        {
            if (_counter < 10)
            {
                _sweetnesses[_counter++] = sweetness;
            }
        }

        public void RemoveItem(Sweetness sweetness)
        {
            bool status = false;

            for (int index = 0; index < _counter - 1; index++)
            {
                if (sweetness == _sweetnesses[index])
                {
                    status = true;
                }

                if (status)
                {
                    _sweetnesses[index] = _sweetnesses[index + 1];
                }
            }

            if (_counter > 0)
            {
                _counter--;
            }
            else
            {
                _counter = 0;
            }
        }

        public void Sort()
        {
        }

        public void ShowItem()
        {
        }

        public void ShowGift()
        {
            if (_counter is 0)
            {
                Console.WriteLine("The gift is empty!");
            }

            for (int index = 0; index < _counter; index++)
            {
                Console.WriteLine($"{index + 1})\tname: {_sweetnesses[index].Name} ");
                Console.Write($"\tweight: {_sweetnesses[index].Weight.Value}");
                Console.WriteLine($"{_sweetnesses[index].Weight.Measure}");
                Console.Write($"\tcost: {_sweetnesses[index].Price.Value}");
                Console.WriteLine($"{_sweetnesses[index].Price.Currency}");
            }

            Console.WriteLine();
        }
    }
}
