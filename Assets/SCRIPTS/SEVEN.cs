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
    {
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
