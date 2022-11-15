using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TRHEE : MonoBehaviour
{
    // VARIABLE DECLARATION
    [SerializeField] private int number;
    private int result;

    void Start()
    {
        result = number % 5;  //we define result as the module of number and 5

        if (result == 0) //if the module of "number" and 5, it means that it is divisible with 5
        {
            Debug.Log($"The number {number} is divisible with 5, CONGRATULATIONS!!");
        }
        else
        {
            Debug.Log($"The number {number} is not divisible with 5...");
        }
    }
}
