using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keypad : Interactible
{

    //This function is where we will design our inteaction using code
    protected override void Interact()
    {
        Debug.Log("Interacted with" + gameObject.name);
    }


}
