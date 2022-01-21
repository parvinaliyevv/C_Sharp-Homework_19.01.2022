using System;

namespace homework2
{
    class City : IComparable
    {
        public int Population { get; init; }

        public City(int population)
        {
            Population = population;
        }

        public int CompareTo(object obj)
        {
            if (obj is not City) throw new ArgumentException(nameof(obj));

            if (this.Population == (obj as City).Population) return 0;
            else if (this.Population > (obj as City).Population) return 1;

            return -1;

        }
    }
}
