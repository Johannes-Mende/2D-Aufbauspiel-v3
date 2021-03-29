using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OreInventory : MonoBehaviour
{
    #region Ore
    public new string name;
    public float maxAmount;
    public float currentAmount;
    public TMPro.TMP_Text maxAmounttext;
    public TMPro.TMP_Text currentAmounttext;
    #endregion
    
    
    public bool PlayerInRange;

    void Start()
    {
        
    }

    void Update()
    {
        maxAmounttext.SetText(maxAmount.ToString());            //Konvertieren von den Float werten in Text für Text Mesh Pro
        currentAmounttext.SetText(currentAmount.ToString());

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            PlayerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        PlayerInRange = false;
    }
}
