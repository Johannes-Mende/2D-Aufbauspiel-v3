using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu (fileName = "NewOre")]
public class Ore : ScriptableObject
{
    public new string name;
    public Sprite Sprite; 
    public float maxAmount;
    public float currentAmount;
    public float refillAmount;
    public float timeinterval = 10f;
    public bool refillrateActiv;

}
