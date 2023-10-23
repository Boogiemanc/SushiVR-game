using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;



public class SHUffle_sushi : MonoBehaviour
{
    public static SHUffle_sushi instance;
    [SerializeField] private List<Item> requiedsushi = new List<Item>();
    [SerializeField] public List<Item> todaysspecial = new List<Item>();
    public List<GameObject> UILIST = new List<GameObject>();
    public GameObject titledisplay;
    
    // Start is called before the first frame update
    void Start()
    {
        titledisplay.GetComponent<Text>().text = "Today's special ";

        for (int i = 0; i < requiedsushi.Count; i++)
        {
            Item temp = requiedsushi[i];
            int randomIndex = Random.Range(i, requiedsushi.Count);
            requiedsushi[i] = requiedsushi[randomIndex];
            requiedsushi[randomIndex] = temp;
        } 

        for(int j = 0; j < todaysspecial.Count; j ++)
        {
            todaysspecial[j] = requiedsushi[j];
            todaysspecial[j].istoday = true;
                 UILIST[j].GetComponent<Text>().text =  todaysspecial[j].itemName;

        }


       
    }


     public bool Checkisspecial(SUSHI sushi)
    { int i = 0;
        bool isTOday = false;

        while (isTOday =false)
        {
          if (  todaysspecial[i].itemName == sushi.Item.itemName)
            {
                isTOday = true;
            } 

            i++;


        }


        return isTOday;

    }
}
