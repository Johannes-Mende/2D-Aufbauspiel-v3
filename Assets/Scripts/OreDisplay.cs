using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OreDisplay: MonoBehaviour
{
    public Ore ore; 
    
    public TMPro.TMP_Text maxAmounttext;
    public TMPro.TMP_Text currentAmounttext;
    public TMPro.TMP_Text refillAmounttext;
    void Start()
    {
        InvokeRepeating("Refillratecalc" ,1, ore.timeinterval);
        InvokeRepeating("Erzcheck" ,1, 5f);
    }

 
    void Update()
    {
        maxAmounttext.SetText(ore.maxAmount.ToString());            //Konvertieren von den Float werten in Text für Text Mesh Pro
        currentAmounttext.SetText(ore.currentAmount.ToString());
        refillAmounttext.SetText(ore.refillAmount.ToString());
        
    }
    //private void FixedUpdate() {
        
    //}

    public void Refillratecalc()
    {
        if (ore.currentAmount >= ore.maxAmount)
        {
            Debug.Log("Silver Ore is Full");                //to do Coroutine
            ore.refillrateActiv = false;
            if(ore.currentAmount > ore.maxAmount) 
            {
                ore.currentAmount = ore.maxAmount;      // Das Erz kann nicht mehr als Maximum Capacity haben
            } 
            if(ore.refillrateActiv == false)
            {
                CancelInvoke("Refillratecalc");
            }  
        }
        else
        {
            ore.refillrateActiv = true;
            if (ore.refillrateActiv == true)
            {
                ore.currentAmount += ore.refillAmount;
            }    
        }        
    }

    public void Erzcheck()
    {
        if(ore.currentAmount < ore.maxAmount)
        {
            ore.refillrateActiv = true;
            Debug.Log("Wird wieder Aufgefüllt");
            //CancelInvoke("Refillratecalc");
        }
        else
        {
            InvokeRepeating("Erzcheck" ,1, 5f);
        }
    }
}

