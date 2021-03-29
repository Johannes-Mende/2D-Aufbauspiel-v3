using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class tets: MonoBehaviour
{
   /* public Ore ore;                           //this Script belong to Silverore Prefab
    
    public TMPro.TMP_Text maxAmounttext;
    public TMPro.TMP_Text currentAmounttext;
    public TMPro.TMP_Text refillAmounttext;

     
    void Start()
    {
        StartCoroutine("Refillratecalc",1f);
    }

 
    void Update()
    {
        maxAmounttext.SetText(ore.maxAmount.ToString());            //Konvertieren von den Float werten in Text für Text Mesh Pro
        currentAmounttext.SetText(ore.currentAmount.ToString());
        refillAmounttext.SetText(ore.refillAmount.ToString());
        
    }
        //https://www.youtube.com/watch?v=hp-8TgTmkTI Coroutinen
    private IEnumerator Refillratecalc()            // in()bool refillrateActiv aber Fehler
    {
        Debug.Log("Fehler");
        while(ore.currentAmount >= ore.maxAmount)
        {
           ore.currentAmount += ore.refillAmount;
           Debug.Log("Rechung ist geglückt");
            yield return new WaitUntil(() => ore.refillrateActiv = true);
        }
    }
    */
}