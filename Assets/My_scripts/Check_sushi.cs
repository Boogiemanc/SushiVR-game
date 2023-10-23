using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class Check_sushi : MonoBehaviour
{
   public score Sc;
    public int mark ;
    public GameObject Scoreboard;
    public GameObject Messageboard;
    Item item;
    SHUffle_sushi sushi1;
    audiotrigger audioplay;

    public static Check_sushi instance;
    // Start is called before the first frame update

    private void Awake()
    {
       
    }
    void Start()
    {
        
        Scoreboard.GetComponent<Text>().text = "Score" + mark;
        Messageboard.GetComponent<Text>().text = "No sushi deliver";
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider food)
    {
        Debug.Log(food.name);
        if (food.gameObject.tag == ("sushi"))
        { SUSHI sushi = food.gameObject.GetComponent<SUSHI>();
            int point = sushi.Item.Points;

            bool v = sushi.Item.istoday;
            

            if (v == true) {

                point = point * 2;

                Debug.Log("isspecical");

            }
            string sushiname = sushi.Item.itemName;
            Debug.Log("Points" + sushi.Item.Points);
            mark = mark + point;

            Sc.Playerscore = mark;
            Messageboard.GetComponent<Text>().text = "sushi delivered: " + sushiname + "!!!!";
            Scoreboard.GetComponent<Text>().text = "Score : " + mark;
            food.gameObject.SetActive(false);
            Audio_Controller.instance.playcorrect();

        } else
            Debug.Log("hmm" + food);
        


    }

   



}
