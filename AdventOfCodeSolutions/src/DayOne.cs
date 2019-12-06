using System;
using System.Collections.Generic;
using System.Linq;

public class DayOne 
{
    public decimal Solve(string fileContents)
    {
        var results = ParseFile(fileContents);
        return results.Sum();
    }

    private List<decimal> ParseFile(string fileContents)
    {
        var result = new List<decimal>();

        var numberArr = fileContents.Split('\n');
        foreach(var num in numberArr)
        {
            if(string.IsNullOrWhiteSpace(num))
                continue;
                            
            var decNumber = decimal.Parse(num);
            var fuelCount = Math.Floor(decNumber / 3) - 2;
            result.Add(fuelCount);
        }

        return result;
    }
}