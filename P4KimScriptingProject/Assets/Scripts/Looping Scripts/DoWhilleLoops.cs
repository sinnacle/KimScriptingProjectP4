using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoWhilleLoops : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //declaring a boolean variable to use in my do while loop
        bool shouldContinue = false;

        //my do while loop is going to check if the boolean variable is true and if it is,
        //it will print a message to the console

        do
        {
            Debug.Log("Hello World");
        } while (shouldContinue == true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
