// See https://aka.ms/new-console-template for more information
using ObjectOrientedOdyssey;

Console.WriteLine("Hello, World!");
// clasa Main, int main din cpp
// Creem obiecte de tipul Calculator
Calculator calculatorDefault = new(); // apelat prin constructor default, se creaza obiect
Calculator calculatorCustom = new("Nvidia", "Lenovo", "SSD", 240, 16);

// Creem obiecte de mai multe tipuri
CalculatorLaptop laptopulPtFaculta = new(); // apeleaza constructorul default de la Calculator
CalculatorLaptopGaming laptopulLuiVericu = new(); // apeleaza constructorul default de la CalculatorLaptop
CalculatorDesktop calculatorulDeLaBunici = new(); // apeleaza constructorul default de la Calculator
Procesor exempluProcesor = new("Intel", "Core i7-10700K", 3.8, 8); // clasa separata, apeleaza propriul constructor

// Get the values of the object's member variables using its getters
int ram = calculatorCustom.GetRam();
int sursa = calculatorCustom.GetSursa();
string gpu = calculatorCustom.GetGpu();
string marca = calculatorCustom.GetMarca();
Procesor procesor = calculatorCustom.GetProcesor();
string stocare = calculatorCustom.GetStocare();

// Output the values of the member variables to the console

// pt calculator facut cu constructor custom // polymorphism static -> compile time
calculatorCustom.AfiseazaDateleObiectului();
calculatorCustom.AfiseazaDateleObiectului(calculatorCustom.GetRam());

// pt calculatorul facut cu constructor default:
calculatorDefault.AfiseazaDateleObiectului(calculatorDefault.GetRam());

// polymorphism dinamic, prin ref -> runtime
Calculator referintaLaLaptopulPtFaculta = laptopulPtFaculta;
referintaLaLaptopulPtFaculta.AfiseazaDateleObiectului();

