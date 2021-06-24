using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public class player : MonoBehaviour
{
    
    public static player access;
    public bool grounded;
    public LayerMask layer;
    public float rayDistance;
    public Vector2 jumpForce;


    public GameObject selectedObject;       //Raycasthit2D
    public Tilemap tiles;
    public Tile tile;
    public Vector3Int location;

    void Awake()
    {
        Application.targetFrameRate = 60;
        access = this;
        tiles = GameObject.Find("Tilemap").GetComponent<Tilemap>(); //GetT
    }
    
    private void Update()
    {
        grounded = IsGrounded();
        Debug.DrawRay (transform.position, -Vector2.up, Color.red, rayDistance);
        Mining();

        if(Input.GetMouseButton(0))
        {
            Vector3 mp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            location = tiles.WorldToCell(mp);
            tiles.SetTile(location, tile);
        }
        if(Input.GetMouseButtonDown(1))
        {
            GetT();
        }
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
    
    public void Mining()
    {
        /*Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hitData = Physics2D.Raycast(new Vector2(worldPosition.x, worldPosition.y), Vector2.zero, 0, LayerMask.GetMask("Tilemap"));

    
           if (hitData && Input.GetMouseButtonDown(0))
                {
                    Debug.Log("Hit und Weg");                       //https://www.youtube.com/watch?v=zABMvbTyEK8
                    selectedObject = hitData.transform.gameObject;
                    worldPosition = tiles.WorldToCell();
                    Destroy(selectedObject);
                }
        */

    }

    void GetT()
    {
        Vector3 mp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        tiles.SetTile(location, tile);

        if(tiles.GetTile(location))
        {
            Debug.Log("Tile");
        }
        else
        {
            Debug.Log("No Tile");
        }
    }
}
