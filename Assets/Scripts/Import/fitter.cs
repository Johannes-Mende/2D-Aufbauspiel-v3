using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode] [RequireComponent(typeof(SpriteRenderer),typeof(BoxCollider2D))]

public class fitter : MonoBehaviour
{
    public Vector2 Offset;
    void Awake()
    {
       GetComponent<BoxCollider2D>().size = GetComponent<SpriteRenderer>().size + Offset;
       GetComponent<BoxCollider2D>().offset =  new Vector2 (0, 0);
    }

   
}
