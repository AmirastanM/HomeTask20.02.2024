

// Method yazirsiz, Method stringden ibaret array ve char qebul edir. Method arrayin icerisinde gelen chardan ne qederdirse onlarin sayini geriye qaytarsin.



using Microsoft.VisualBasic;
using System;

int SumOfCounts(string[] array, char edeler)
{
    int count = 0;
    foreach (string str in array)
    {
        count += str.Count(m => m == edeler);
    }
    return count;
}

int result = SumOfCounts(string "");

SumOfCounts("salam") ;
