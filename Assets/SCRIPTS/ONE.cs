using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ONE : MonoBehaviour
{
    // VARIABLE DECLARATION
    public float number;
    void Start()
    {
        if(number > 1)
        {
            Debug.Log($"The number {number} is positive.");

        }else if(number == 0)
        {
            Debug.Log($"The number is 0.");
        }
        else
        {
            Debug.Log($"The number {number} is negative.");
        }
    }
}
