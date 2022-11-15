using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FIVE : MonoBehaviour
{
    // VARIABLE DECLARATION
    [SerializeField] private int age; 

    void Start()
    {
        if(age >= 18) //if the age is grater of 18 will be of legal age
        {
            Debug.Log($"Hello, you are {age} years old, so you are of legal age.");
        }
        else 
        {
            Debug.Log($"Hello, you are {age} years old, so you are NOT of legal age.");
        }
    }
}
