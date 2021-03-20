using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{
    public GameObject Camera1;
    public GameObject Camera2;

    void Update()
    {
        if (Input.GetButton("MapCamera"))
        {
            Camera1.SetActive(false);
            Camera2.SetActive(true);
        }
        else
        {
            Camera1.SetActive(true);
            Camera2.SetActive(false);
        }
    }
}
