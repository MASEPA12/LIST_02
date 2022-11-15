using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEVEN : MonoBehaviour
{
    //VARIABLE DECLARATION 
    public string kindOfOperation;
    public float X;
    public float Y;

    void Start()
    {               //depending on the type of operation a different function is called
        if (kindOfOperation == "sum")
        {
            float result = sum(X, Y);
        }else if(kindOfOperation == "subtraction")
        {
            float result = subtraction(X, Y); 
        }else if(kindOfOperation == "product")
        {
            float result = product(X, Y); 
        }else if(kindOfOperation == "division")
        {
            float result = division(X, Y);
        }
        else
        {
            Debug.Log("You have to choose the kinf of operation you want to do (sum, subtraction, product or division.)");
        }
    }

    //here I've defined the functions will be called depending on the kind of operation
    private float sum(float X, float Y)
    {
        float result = X + Y;
        Debug.Log($"{X} + {Y} = {result}");
        return result;
    }
    private float subtraction(float X, float Y)
    {
        float result = X - Y;
        Debug.Log($"{X} - {Y} = {result}");
        return result;
    }
    private float product(float X, float Y)
    {
        float result = X * Y;
        Debug.Log($"{X} x {Y} = {result}");
        return result;
    }
    private float division(float X, float Y)
    {
        float result = X / Y;
        Debug.Log($"{X} / {Y} = {result}");
        return result;
    }

}
