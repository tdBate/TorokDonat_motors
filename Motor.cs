using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motors
{
    internal class Motor
    {
        private string brand;
        private string name;
        private int releaseYear;
        private int performance;
        private int priceInEur;

        public Motor(string brand, string name, int releaseYear, int performance, int priceInEur)
        {
            this.brand = brand;
            this.name = name;
            this.releaseYear = releaseYear;
            this.performance = performance;
            this.priceInEur = priceInEur;
        }

        public string Brand { get => brand;}
        public string Name { get => name;}
        public int ReleaseYear { get => releaseYear; }
        public int Performance { get => performance; }
        public int PriceInEur { get => priceInEur; }



    }
}
