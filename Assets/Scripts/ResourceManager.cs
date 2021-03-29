using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    public OreInventory OInv;
    public PlayerInventory PInv;
    //public float SilverAmountplayer;
    void Start()
    {
        
    }

    void Update()
    {
      if(Input.GetMouseButtonDown(0))
      {
        Abbau();
      }
    }

    private void Abbau()
    {
        if(OInv.PlayerInRange == true)
        {
            Debug.Log("Abbau");
            OInv.currentAmount -= PInv.PlayerAbbauAmount;
            PInv.SilverAmountplayer += PInv.PlayerAbbauAmount;
        }
        
    }

}
