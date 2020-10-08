using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Converter
    {
        private Dictionary<string, Dictionary<string, double>> _rates = 
            new Dictionary<string, Dictionary<string, double>>();

        public Converter(double usd, double eur)
        {
            _rates.Add("uah", new Dictionary<string, double>());
            _rates["uah"].Add("uah", 1);
            _rates["uah"].Add("usd", 1 / usd);
            _rates["uah"].Add("eur", 1 / eur);

            _rates.Add("usd", new Dictionary<string, double>());
            _rates["usd"].Add("usd", 1);
            _rates["usd"].Add("eur", usd / eur);
            _rates["usd"].Add("uah", usd);

            _rates.Add("eur", new Dictionary<string, double>());
            _rates["eur"].Add("eur", 1);
            _rates["eur"].Add("usd", eur / usd);
            _rates["eur"].Add("uah", eur);
        }

        public double Convert(string from, string to, double val)
        {
            return _rates[from][to] * val;
        }
    }

}
