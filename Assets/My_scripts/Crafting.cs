using System.Collections;
using System.Collections.Generic;
using System;
using System.Linq;
using UnityEngine;

[Serializable]
public struct ItemAmount
{
    public Item Item;
    [Range(1,999)]
    public int Amount;
}
[CreateAssetMenu]
public class Crafting : ScriptableObject 
{
    public List<Item> Materials ;
    public List<Item> Results ;


    public int Materialcount
    {
        get { return Materials != null ? Materials.Count : 0; }
    }
   
    public bool IsMatchsushi(Item A, Item B )
    { 
        
        if (Materials == null || Materials.Count != 2) return false;
        if (Materials[0] == A)
            return Materials[1] == B;
        else if (Materials[1] == A)
            return Materials[0] == B;
        else
            return false;



    } 

    

  
}
