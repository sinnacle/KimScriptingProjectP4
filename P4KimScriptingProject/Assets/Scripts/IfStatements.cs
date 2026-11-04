using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotTemperature = 70.0f;
    float coldTemperature = 40.0f;
    // Start is called before the first frame update
    void Start()
    {
 
    }
    // Update is called once per frame
    void Update ()
    {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                TemperatureTest();
            }
            coffeeTemperature -= Time.deltaTime * 5f;
    }    

    void TemperatureTest()
    {
                //This if statement is going to check the temperature of my coffee
                if (coffeeTemperature >= hotTemperature)
                {
                    Debug.Log("The coffee is too hot to drink");
                }
                //This else if statement is going to check the temperature of my coffee
                else if (coffeeTemperature <= coldTemperature)
                {
                    Debug.Log("The coffee is too cold to drink");
                }
                //This else statement is going to check the temperature of my coffee
                else
                {
                    Debug.Log("The coffee is just right");
                }
    }
}
