using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Trigger : MonoBehaviour
{
    public UnityEvent onTrigger;
    // Start is called before the first frame update
   void TriggerScript()
    {
        onTrigger.Invoke();

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("material") == false)
        {

            TriggerScript();
            Debug.Log(other.name);
        }
        
    }
}
