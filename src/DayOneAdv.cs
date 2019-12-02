using System;
using System.Collections.Generic;
using System.Linq;

public class DayOneAdv 
{
    public decimal Solve(string fileContents)
    {
        var results = ParseFile(fileContents);
        return results.Sum();
    }

    private decimal GetFuel(decimal mass)
    {
        var fuelCount = Math.Floor(mass / 3) - 2;
        if(fuelCount <= 0)
            return 0;

        return fuelCount + GetFuel(fuelCount);
    }

    private List<decimal> ParseFile(string fileContents)
    {
        var result = new List<decimal>();

        var numberArr = fileContents.Split('\n');
        foreach(var num in numberArr)
        {
            if(string.IsNullOrWhiteSpace(num))
                continue;
            
            var mass = decimal.Parse(num);
            var fuelCount = GetFuel(mass);
            result.Add(fuelCount);
        }

        return result;
    }
}