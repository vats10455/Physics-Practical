using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLight : MonoBehaviour
{


    public GameObject theLight = null;

    private void OnMouseDown()
    {
        if (theLight != null && theLight.GetComponent<Light>() != null)
            theLight.GetComponent<Light>().enabled = !theLight.GetComponent<Light>().enabled;
    }
}