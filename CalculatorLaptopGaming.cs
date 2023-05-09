using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedOdyssey;

// clasa D din diagrama
internal class CalculatorLaptopGaming : CalculatorLaptop
{
    private int refreshRateEcran;
    private string sistemDeRacire;

    // Default constructor
    public CalculatorLaptopGaming()
    {
        // Initialize default values for fields
        refreshRateEcran = 60;
        sistemDeRacire = "Aer";
    }

    // Parameterized constructor
    public CalculatorLaptopGaming(int refreshRate, string coolingSystem)
    {
        // Set field values based on input parameters
        refreshRateEcran = refreshRate;
        sistemDeRacire = coolingSystem;
    }

    // settere
    public void GetRefreshRateEcran(int rr)
    {
        refreshRateEcran = rr;
    }

    public void SetSistemDeRacire(string sdr)
    {
        sistemDeRacire = sdr;
    }

    // gettere
    public int GetRefreshRateEcran()
    {
        return refreshRateEcran;
    }

    public string GetSistemDeRacire()
    {
        return sistemDeRacire;
    }

    // metode custom
    public void OverclockProcesor()
    {
        // perform overclocking logic here
    }

}