using System;

namespace Hometask;

public class Student
{
    public string Name = "";
    public int GradeLevel;
    // public List<int> TestScores = new List<int>();
    public int[] ?TestScores;


    public double GetAverage()
    {
        int sum = 0;
        for (int i = 0; i < TestScores.Length; i++)
        {
            sum+=TestScores[i];
        }

        return (double)sum / TestScores.Length;
    }
}
