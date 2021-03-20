using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset = new Vector3( 0, 0, -5 );

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = target.position + offset;
    }
}
