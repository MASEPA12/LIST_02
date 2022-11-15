using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FOUR : MonoBehaviour
{
    // VARIABLE DECLARATION
    public float Base;
    public float Height;
    private float BH;
    private float result;

    void Start()
    {
        BH = Base * Height;
        result = BH / 2;

        if (Base > 0 && Height > 0)
        {
            Debug.Log($"The area of the triangle witch base is {Base} and height {Height} is {result}.");
        }
        else
        {
            Debug.Log($"The area cannot be calculated.");
        }
    }
}
