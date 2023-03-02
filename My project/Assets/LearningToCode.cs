using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class LearningToCode
{
    int x;
    int y;
    bool isThisUseful;
    float notPrecise;
    char theLetterA = 'A'; // Char init always requires single quotes
    string FirstLineOfHamlet = "Who's there?"; // String init always requires double quotes
    char oneLittleChar;

    /*
     * Fun little notes:
     * 
     * C# conventions:
     * var names start with lowercase letter
     * function names start with uppercase letter
     * class names start with an uppercase letter
     * private vars start with underscores
     * static vars can be all caps with snake case
     * 
     * Instance vars and functions
     * These vars and functions are tied directly to a single instance of the variable type
     * 
     * Static class variables and functions
     * static vars are tied to entire class rather than being tied to an individual instance.
     * This is like doctor who worm-holes. Or teleporting with the TARDIS
     * 
     * Class instances and static functions
     * instances of classes are known as objects or members
     * instances of classes can differ from instance to instance
     * You can reference one instance of a class using more than one variable.
     * When defining a class you can use this interesting bracket notation to allow the class to be seen in the inspector:
     * [System.Serializable]
     * 
     * Unity or C# (not sure which it's native to) have a Vector3 class
     * Vector3 pos = new Vector3(0.0f, 3.0f, 4.0f)
     * Color class that has static vars: red,green,blue,cyan,magenta,yellow,black,white,grey/gray,clear
     */

    // Start is called before the first frame update
    void Start()
    {
        x = 10;
        y = x - 4;
        x = 12;
        isThisUseful= false;
        notPrecise = 1.0f / 3.0f;
        oneLittleChar = FirstLineOfHamlet[0]; // W is the 0th char in the string
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
