using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detection : MonoBehaviour
{
    Crafting_check crafting_Check;
   GameObject Dectectedmaterials;

    private void Awake()
    {
        crafting_Check = Crafting_check.Instance;

       
    }


    private void Update()
    {
        
    }

    // Start is called before the first frame update
  /*  private void OnTriggerEnter(Collider rawmaterials)
    {
        Dectectedmaterials = rawmaterials.gameObject;
        if (rawmaterials != null)
        {
            if (rawmaterials.gameObject.CompareTag ("material"))

            { crafting_Check.InsertyToList(Dectectedmaterials); }
        } else
        {
            Debug.Log("No rawmaterials!");
        }
    }*/
}
