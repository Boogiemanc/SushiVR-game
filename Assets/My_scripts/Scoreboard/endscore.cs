using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endscore : MonoBehaviour
{
    public GameObject uis;

    public score sc;
    int point;

     void Start()
    {


        point = sc.Playerscore ;
        Debug.Log("point"+point);
        
    }

     void Update()

    {
        uis.GetComponent<Text>().text = "Your final score :" + point;
    }

}
