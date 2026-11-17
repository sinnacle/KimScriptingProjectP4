using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherClass : MonoBehaviour
{
    public int apples;
    public int bananas;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //creating a method that takes in 2 parameters
    public void FruitMachine(int a, int b)
    {
        //create a local variable to the method
        int answer;

        //add the 2 parameters together and assign it to the last variable
        answer = a + b;
        //print the answer to the console
        Debug.Log("The answer is " + answer);
    }
}
