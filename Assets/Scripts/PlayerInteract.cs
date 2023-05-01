using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    private Camera cam;

    [SerializeField]
    private LayerMask mask;
    [SerializeField]
    private float distance = 3f;


    private void Start()
    {
        cam = GetComponent<PlayerLook>().cam;
    }

    private void Update()
    {
        //Creates a ray at the center of the camera, shooting outwards.
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * distance);

        // variable to store our collision information.
        RaycastHit hitInfo;
         
        if(Physics.Raycast(ray,out hitInfo,distance, mask))
        {
            if(hitInfo.collider.GetComponent<Interactible>() != null)
            { 
                Debug.Log(hitInfo.collider.GetComponent<Interactible>().promptMessage);
            }
        }
    }

}
