using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TWO : MonoBehaviour
{
    // VARIABLE DECLARATION
    public int yearOfBirth;
    private int result;

    void Start()
    {       //we define the result of "result", which will depend on the number of "yearOfBirth". 
        result = yearOfBirth % 12;

        if (result == 4)
        {
            Debug.Log($"If you were born in {yearOfBirth}, your Chinese horoscope is RAT.");
        }
        else if (result == 5)
        {
            Debug.Log($"If you were born in {yearOfBirth}, your Chinese horoscope is OX.");
        }
        else if (result == 6)
        {
            Debug.Log($"If you were born in {yearOfBirth}, your Chinese horoscope is TIGER.");
        }
        else if (result == 7)
        {
            Debug.Log($"If you were born in {yearOfBirth}, your Chinese horoscope is RABBIT.");
        }
        else if (result == 8)
        {
            Debug.Log($"If you were born in {yearOfBirth}, your Chinese horoscope is DRAGON.");
        }
        else if (result == 9)
        {
            Debug.Log($"If you were born in {yearOfBirth}, your Chinese horoscope is SNAKE.");
        }
        else if (result == 10)
        {
            Debug.Log($"If you were born in {yearOfBirth}, your Chinese horoscope is HORSE.");
        }
        else if (result == 11)
        {
            Debug.Log($"If you were born in {yearOfBirth}, your Chinese horoscope is GOAT.");
        }
        else if (result == 0)
        {
            Debug.Log($"If you were born in {yearOfBirth}, your Chinese horoscope is MONKEY.");
        }
        else if (result == 1)
        {
            Debug.Log($"If you were born in {yearOfBirth}, your Chinese horoscope is ROOSTER.");
        }
        else if (result == 2)
        {
            Debug.Log($"If you were born in {yearOfBirth}, your Chinese horoscope is DOG.");
        }
        else
        {
            Debug.Log($"If you were boen in {yearOfBirth}, your Chinease horoscope is PIG");
        }
    }
}
