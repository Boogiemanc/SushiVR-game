using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]
public class Cross : MonoBehaviour
{

   // public GameObject sushi;
    //int sushirott = 0;

    public GameObject[] CRoss;
    

   
     void Start()
    {
       for ( int i = 0; i< 3; i++)
        {
            CRoss[i].SetActive(false);
        }
        //sushi = GameObject.FindGameObjectWithTag("sushi");
       // sushirott = sushi.GetComponent<SUSHI>().Rot;
    }
    // Update is called once per frame
    void Update()
    {
       // Debug.Log("SUSHI" + sushirott);
        //countrottensushi(sushirott);
     

    }
   
    public void countrottensushi( int rottennumber)
    {
        

        if (rottennumber == 1)
        {
            CRoss[0].SetActive(true);
            Debug.Log("Sushi rotten!");
        }
        if (rottennumber == 2)
        {
            CRoss[1].gameObject.SetActive(true);
            Debug.Log("Sushi rotten!");
        }
        if (rottennumber == 3)
        {
            CRoss[2].gameObject.SetActive(true);
            Debug.Log("Sushi rotten!");
        }
    }
}
