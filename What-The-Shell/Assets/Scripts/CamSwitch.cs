using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{
    /*JOHN PROFESSIONAL CODE */
    public GameObject Camera1;
    public GameObject Camera2;
    /*JOHN PROFESSIONAL CODE ABOVE ^^*/
    public bool camSwitch = false;

    void Update()
    {
        Camera1.SetActive(camSwitch);
        Camera2.SetActive(!camSwitch);
        if (Input.GetButtonDown("MapCamera"))
        {
            camSwitch = !camSwitch;
            //Camera1.SetActive(false);
            //Camera2.SetActive(true);
        }
        else
        {
            //Camera1.SetActive(true);
            //Camera2.SetActive(false);
        }
    }
}
