using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomView : MonoBehaviour
{
    private Camera toZoom;
    private float fov; //field of view


    private void Start()
    {
        
        toZoom = GetComponent<Camera>();
        fov = toZoom.fieldOfView;
    }

    private void Update()
    {
        if(Input.GetButton("Zoom"))
        {
            toZoom.fieldOfView = fov/1.5f;
        }
        else
        {
            toZoom.fieldOfView = fov;
        }
    }
}
