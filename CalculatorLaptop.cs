using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedOdyssey
{
    internal class CalculatorLaptop : Calculator
    {
        protected int batteryLife;
        protected double weight;
        public CalculatorLaptop()
        {
            // Default constructor
            this.batteryLife = 0;
            this.weight = 2.3;
        }

        public CalculatorLaptop(int b, double w)
        {
            // Constructor with parameters
            this.batteryLife = b;
            this.weight = w;
        }

        // Destructor not needed in C#

        public override void SetRam(int rm)
        {
            // Method override
            this.ram = rm;
        }

        public void SetBatteryLife(int life)
        {
            this.batteryLife = life;
        }

        public void SetWeight(double w)
        {
            this.weight = w;
        }

        public int GetBatteryLife()
        {
            return this.batteryLife;
        }

        public double GetWeight()
        {
            return this.weight;
        }

        public string CalculateBatteryLife()
        {
            // Custom method
            // Implementation left as exercise for the reader
            throw new NotImplementedException();
        }

        public override void AfiseazaDateleObiectului()
        {
            Console.WriteLine("Laptop: " + "Baterie:" + batteryLife + "%, Greutate: " + weight);
        }
    }
}