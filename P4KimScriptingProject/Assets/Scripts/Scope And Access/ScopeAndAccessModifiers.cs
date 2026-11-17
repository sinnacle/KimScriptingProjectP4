using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAndAccessModifiers : MonoBehaviour
{
    //adding a public variable to the class
    public int alpha = 5;
    //adding a private variable to the class
    private int beta = 0;
    private int gamma = 5;

    //add access to another class
    private AnotherClass myOtherClass;

    // Start is called before the first frame update
    void Start()
    {
        //change the starting value of alpha
        alpha = 8;
        //I can change or access another class
        myOtherClass = new AnotherClass();
        //I am going to use the method in another class
        myOtherClass.FruitMachine(alpha, myOtherClass.apples);

    }
    //create an example method takes in 2 parameters
    public void ExampleMethod(int pens, int crayons)
    {
        //create a local variable to the method
        int answer;
        //multiply the 2 parameters together and assign it to the local variable
        answer = pens * crayons * alpha;
        //print the answer to the console
        Debug.Log("The answer is: " + answer);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Alpha is set to: " + alpha);
    }
}
