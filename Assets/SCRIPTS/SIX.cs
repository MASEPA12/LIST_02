using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SIX : MonoBehaviour
{
    // VARIABLE DECLARATION
    public float distanceTravelled;
    [SerializeField] private float totalDistance;
    private float resultDistanceLeft;

    void Start()
    {
        resultDistanceLeft = totalDistance - distanceTravelled;     //determine the amounts of meters remains

        if (resultDistanceLeft == 0f) //if there are 0 meters left;
        {
            Debug.Log("Congratulations! You have completed the total distance.");
        }
        else
        {
            Debug.Log($"Oh… You still have {resultDistanceLeft} meters left to complete the total distance.");
        }
    }
}
