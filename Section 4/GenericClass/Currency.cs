using System;

namespace CurrencyClass;

public class Currency
{
    public Currency(string name, string fullName, double rate)
    {
        Name = name;
        FullName = fullName;
        Rate = rate;
    }
    public string Name{get; set;}
    public string FullName{get; set;}
    public double Rate{get; set;}
}
