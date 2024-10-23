using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Your comment here

/*
Develpoed by Ross Elliott
Date Modified 27/09/24
From Hadi Mehrpouya's tutorials
 */

public class MyHelloWorld : MonoBehaviour
{
    //writing a code that priunts the age difference between two living things!
    int myAge = 88;
    int oldestTreeAge = 4855;
    //int number1 = 999;
    //int number2 = 111111;

    // Start is called before the first frame update

    void Start()//Start function only runs once. 
    {
        int ageDifference = oldestTreeAge - myAge;

        Debug.Log("the age difference is: " + ageDifference);
        //Debug.Log(ageDifference);
        /*
        Debug.Log("the numberone is ", number1);
        Debug.Log("the numbertwo is ", number2);
        */
        //Debug.Log("Value of my first variable before change");
        //Debug.Log(myFirstNumberVariable);
        //Debug.Log("Value of my first variable after change");
        //myFirstNumberVariable = 5;  // Changing the value of my variable
        //Debug.Log(myFirstNumberVariable);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
