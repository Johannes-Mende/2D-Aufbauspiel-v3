using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    
    public static player access;
    public bool grounded;
    public LayerMask layer;
    public float rayDistance;
    public Vector2 jumpForce;
    void Awake()
    {
        Application.targetFrameRate = 60;
        access = this;
    }
    
    private void Update()
    {
        grounded = IsGrounded();
        Debug.DrawRay (transform.position, -Vector2.up, Color.red, rayDistance);
    }
    
    bool IsGrounded()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.up, rayDistance, layer);
        if (hit.collider != null)
            return true;
        else
            return false;
    }
    public void Jump()
    {
        if(IsGrounded())
        {
            Debug.Log("jump");
            GetComponent<Rigidbody2D>().AddForce(jumpForce, ForceMode2D.Impulse);
        }
        
    }
    
}
