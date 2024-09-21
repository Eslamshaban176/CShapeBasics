
using System;
using EnumAlternative;
public class Program
{
    private static void Main(string[] args)
    {

        foreach (var country in Country.GetCountries())
        {
            Console.WriteLine(country);
        }
    }
}