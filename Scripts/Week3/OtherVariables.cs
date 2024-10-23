using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Experimenting with other types of variables
public class OtherVariables : MonoBehaviour
{
    public int myAge = 101;
    float accurateAge = 88.9f;
    string myName = "Ross";
    bool am_I_Alive = true;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("The accurate age is: " + accurateAge);
        Debug.Log("Welcome " + myName);

        // Your first if statement in C#
        /*
        if (//write our condition)
        {
            What to do if the condition is true
        }



        */
        if( myAge >= 100)
        {

            Debug.Log("Have you recieved a letter from the king yet?");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
