using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class input : MonoBehaviour
{
    [Range(0,2)]
    public float WSSpeed, ADSpeed;
    public float AxisWS, AxisAD;

    void LateUpdate()
    {
        
        AxisAD = Input.GetAxis("Horizontal");
        AxisWS = Input.GetAxis("Vertical");
        player.access.gameObject.transform.Translate(new Vector3(AxisAD*ADSpeed*Time.deltaTime,0,0));

        if(Input.GetKeyDown(KeyCode.Space))
            player.access.Jump();

        if (Input.GetKeyDown(KeyCode.E))
        {
           
        }

            if (AxisAD>0)
        {
            player.access.gameObject.transform.localScale = new Vector3(1, player.access.gameObject.transform.localScale.y, player.access.gameObject.transform.localScale.z);
            if (player.access.grounded)
            {
                player.access.GetComponent<Animator>().SetBool("runBool", true);
            }
            else
            {
                player.access.GetComponent<Animator>().SetBool("runBool", false);
            }
        }
        else if (AxisAD<0)
        {
            player.access.gameObject.transform.localScale = new Vector3(-1, player.access.gameObject.transform.localScale.y, player.access.gameObject.transform.localScale.z);
            if (player.access.grounded)
            {
                player.access.GetComponent<Animator>().SetBool("runBool", true);
            }
            else
            {
                player.access.GetComponent<Animator>().SetBool("runBool", false);
            }
        }
        else
            player.access.GetComponent<Animator>().SetBool("runBool", false);
    }

}
