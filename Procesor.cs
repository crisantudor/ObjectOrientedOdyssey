using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedOdyssey
{
    // clasa E din diagrama
    class Procesor
    {
        private string producator;
        private string model;
        private double frecventa;
        private int numarNuclee;

        // constructor
        public Procesor()
        {
            producator = "-";
            model = "-";
            frecventa = 0.0;
            numarNuclee = 0;
        }

        public Procesor(string prod, string mod, double freq, int nuclee)
        {
            producator = prod;
            model = mod;
            frecventa = freq;
            numarNuclee = nuclee;
        }

        // destructor
        ~Procesor()
        {
            // any cleanup code here
        }

        // settere
        public void SetModel(string mod)
        {
            model = mod;
        }

        public void SetFrecventa(double freq)
        {
            frecventa = freq;
        }

        public void SetNumarNuclee(int nuclee)
        {
            numarNuclee = nuclee;
        }

        public void SetProducator(string prod)
        {
            producator = prod;
        }

        // gettere
        public string GetModel()
        {
            return model;
        }

        public int GetNumarNuclee()
        {
            return numarNuclee;
        }

        public double GetFrecventa()
        {
            return frecventa;
        }

        public string GetProducator()
        {
            return producator;
        }
    }
}
