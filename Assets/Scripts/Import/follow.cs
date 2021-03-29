using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    private Vector3 desiredPosition, smoothedPosition;
    public Vector3 offset;

    public float smooth = 1;
    public bool followY;
    public GameObject target;
    void Update()
    {
        desiredPosition = target.transform.position + new Vector3(offset.x, offset.y, transform.position.z);
        Vector3 V3;
        if(followY)                                                                                 //Bei If einzeilern kann man die {} klammern weg lassen
        {
            V3 = desiredPosition;
        }
        else
        {
            V3 = new Vector3(desiredPosition.x, transform.position.y, desiredPosition.z);
        }
        smoothedPosition = Vector3.Lerp(transform.position, V3, smooth * Time.deltaTime);
        transform.position = smoothedPosition;

    }
}
