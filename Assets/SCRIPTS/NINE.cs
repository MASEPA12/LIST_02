using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NINE : MonoBehaviour
{
    // VARIABLE DECLARATION
    public bool wantsVegetarianOption;

    void Start()
    { 
        if(!wantsVegetarianOption == true) //if is not true "i dont want vegetarian"
        {
            Debug.Log("Non-vegetarian option coming soon");
        }
        else
        {
            Debug.Log("Vegetarian option coming soon");
        }   
    }
}
