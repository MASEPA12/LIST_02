using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEN : MonoBehaviour
{
    // VARIABLE DELCARAION
    public int year;
    private int result1;
    private int result2;
    private int result3;

    void Start()
    {
        result1 = year % 4; //year/4
        result2 = year % 100; //year/100
        result3 = year % 400; //year/400
        
        
        if (result1 == 0) //if it's divisible by 4
        {
            Debug.Log($"The year {year} is a leap year.");

            if (result2 == 0) //is divisible by 100
            {
                if(result3 == 0) //is divisible by 400?
                {
                    Debug.Log($"The year {year} is a leap year.");
                }
                else
                {
                    Debug.Log($"The year {year} is not a leap year.");
                }
            }
        }
        else
        {
            Debug.Log($"The year {year} is not a leap year.");
        } 
    }
}
