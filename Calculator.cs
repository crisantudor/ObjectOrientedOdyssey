using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedOdyssey
{
    internal class Calculator
    {
        protected string marca;
        protected int ram;
        protected int sursa;
        protected Procesor procesor;
        private string gpu;
        private string stocare;

        public Calculator()
        {
            // Default constructor
            this.gpu = "";
            this.marca = "";
            this.stocare = "";
            this.sursa = 0;
            this.ram = 0;
            this.procesor = new Procesor();
        }

        public Calculator(string gpu, string m, string stoc, int s, int rm)
        {
            // Constructor with parameters
            this.gpu = gpu;
            this.marca = m;
            this.stocare = stoc;
            this.sursa = s;
            this.ram = rm;
            this.procesor = new Procesor();
        }

        public Calculator(Calculator other)
        {
            // Copy constructor
            this.marca = other.marca;
            this.ram = other.ram;
            this.sursa = other.sursa;
            this.procesor = other.procesor;
            this.gpu = other.gpu;
            this.stocare = other.stocare;
        }

        public virtual void AfiseazaDateleObiectului()
        {
            Console.WriteLine("Marca: " + marca + " Ram: " + ram + " Sursa: " + sursa + "W" + " GPU: " + gpu + " Procesor: " + procesor.GetModel() + " Stocare: " + stocare);
        }

        public void AfiseazaDateleObiectului(int r)
        {
            Console.WriteLine("Ram: " + r + " Marca: " + marca + " Sursa: " + sursa + "W" + " GPU: " + gpu + " Procesor: " + procesor.GetModel() + " Stocare: " + stocare);
        }

        public virtual void SetRam(int rm)
        {
            this.ram = rm;
        }

        public void SetSursa(int s)
        {
            this.sursa = s;
        }

        public void SetGpu(string g)
        {
            this.gpu = g;
        }

        public void SetMarca(string m)
        {
            this.marca = m;
        }

        public void SetStocare(string s)
        {
            this.stocare = s;
        }

        public int GetRam()
        {
            return this.ram;
        }

        public int GetSursa()
        {
            return this.sursa;
        }

        public string GetGpu()
        {
            return this.gpu;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public string GetStocare()
        {
            return this.stocare;
        }

        public Procesor GetProcesor()
        {
            return this.procesor;
        }
    }
}
