using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EIGHT : MonoBehaviour
{
    // VARIABLE DECLARATION
    public int number;

    void Start()
    {
        if (number > 100)
        {
            Debug.Log("You have more than 100 points");
        }
        else if (100 >= number && number > 75)
        {
            Debug.Log("You have more than 75 points, but less than or equal to 100");
        }
        else if(75 >= number && number > 50)
        {
            Debug.Log("You have more than 50 points, but less than or equal to 75");
        }
        else if(50 >= number && number > 25)
        {
            Debug.Log("You have more than 25 points, but less than or equal to 50");
        }
        else
        {
            Debug.Log("You have less than or equal to 25 points");
        }

    }
   
}
