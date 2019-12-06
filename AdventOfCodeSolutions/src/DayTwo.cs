using System;
using System.Collections.Generic;
using System.Linq;

public class DayTwo
{
    private List<int> _memoryArr = new List<int>();

    public int Solve(string fileContent, bool emulateAlarm = false)
    {
        _memoryArr = ParseFile(fileContent);
        if(emulateAlarm)
        {
            _memoryArr[1] = 12;
            _memoryArr[2] = 2;
        }
        ProcessProgram();
        return _memoryArr[0];
    }

    private List<int> ParseFile(string fileContent)
    {
        return fileContent.Split(",").Select(x => int.Parse(x)).ToList();
    }

    private void ProcessProgram()
    {
        int i = 0;
        while(true)
        {
            if(i >= (_memoryArr.Count-1))
                return;

            var opCode = _memoryArr[i];
            switch(opCode){
                case 1:
                    AddAndStore(_memoryArr[i+1],_memoryArr[i+2],_memoryArr[i+3]);
                    break;
                case 2:
                    MultiplyAndStore(_memoryArr[i+1],_memoryArr[i+2],_memoryArr[i+3]);
                    break;
                case 99:
                    return;
                default:
                    throw new ArgumentException($"Unknown opcode {opCode}");
            }

            i+=4;
        }
    }

    private void AddAndStore(int numOneIdx, int numTwoIdx, int resIdx)
    {
        var result = _memoryArr[numOneIdx] + _memoryArr[numTwoIdx];
        _memoryArr[resIdx] = result;
    }

    private void MultiplyAndStore(int numOneIdx, int numTwoIdx, int resIdx)
    {
        var result = _memoryArr[numOneIdx] * _memoryArr[numTwoIdx];
        _memoryArr[resIdx] = result;
    }
}