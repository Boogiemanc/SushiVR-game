using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiotrigger : MonoBehaviour
{
    Audio_Controller Audio_Controller;


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("wood"))
        {

            Audio_Controller.instance.playknifehitwood();

        }

         else 
        {

            Audio_Controller.instance.playmetalhit();
        }
    }
}
