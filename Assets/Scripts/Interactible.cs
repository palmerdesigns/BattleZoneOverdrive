using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactible : MonoBehaviour
{
    //message displayed to player when looking at an interactible
    public string promptMessage; 

    public void BaseInteract()
    {
        Interact();
    }

    protected virtual void Interact()
    {
           //we wont have any code written in this function
           //this is a template function to be overriden by our subclasses. 
    }

}
