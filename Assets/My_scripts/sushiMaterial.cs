using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class sushiMaterial : MonoBehaviour
{
   public Item item ;
    private void Awake()
    {
        string materials = item.itemName;
      //  Debug.Log("Sushi ID" + item.Id + " Name:" + materials);
    }
}
