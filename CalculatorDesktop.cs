using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedOdyssey;

// clasa C din diagrama
internal class CalculatorDesktop : Calculator
{
    protected string tipTastatura;
    protected int numarVentilatoare;
    protected List<KeyValuePair<string, int>> hardwareComponents;
    // constructors
    public CalculatorDesktop()
    {
        numarVentilatoare = 6;
        tipTastatura = "RGB";
        hardwareComponents = new List<KeyValuePair<string, int>>();
    }

    public CalculatorDesktop(int nv, string tt) : this()
    {
        numarVentilatoare = nv;
        tipTastatura = tt;
    }

    // destructor
    ~CalculatorDesktop()
    {
        // Do any necessary cleanup here
    }

    // settere
    public void SetNumarVentilatoare(int nv)
    {
        numarVentilatoare = nv;
    }

    public void SetTipTastatura(string tt)
    {
        tipTastatura = tt;
    }

    // gettere
    public int GetNumarVentilatoare()
    {
        return numarVentilatoare;
    }

    public string GetTipTastatura()
    {
        return tipTastatura;
    }

    public List<KeyValuePair<string, int>> GetHardwareComponents()
    {
        return hardwareComponents;
    }

    // metoda custom - un fel de setter, updater
    public void AdaugaComponentaHardware(string name, int price)
    {
        hardwareComponents.Add(new KeyValuePair<string, int>(name, price));
    }
}