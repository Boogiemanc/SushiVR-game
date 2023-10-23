using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]
public class SUSHI : MonoBehaviour
{
    Check_sushi check_Sushi;
    public Cross cross;
    public Item Item;
    string sushi;
    private bool Isrealsushi =false;
   public  bool Istick = false;
    private int Rot = 0;
    private int Rottingtime;
    float timeofrot;
    [SerializeField] Slider slider_1;

      private void Awake()
      {
        // Debug.Log(Item.Isrotten);
        // Debug.Log(Item.ItemModel);
        // Debug.Log(Item.ItemName);
        slider_1.maxValue = Item.RottenTime;
        slider_1.value = Item.RottenTime;
        string sushi = gameObject.name;
        Rottingtime = Item.RottenTime;
        timeofrot = (float)Rottingtime;
    }
    /*    void Checksushi()
        {
            if(sushi == Item.ItemModel)
            {
                Isrealsushi = true;

                Debug.Log(Item.ItemName);

            }
            else
            {
                Debug.LogError("No such sushi exists:" + sushi);
            }//



        }*/
    private void Update()
    {
       // Debug.Log("Item" + sushi + "Can rotten:" + Item.Canrotten);
       // Debug.Log("Item" + sushi + "Is rotten:" + Item.isrotten);
        if (Istick == false && Item.RottenTime > 0 && gameObject.activeSelf == true)
        {
            Debug.Log("ticking");
            //StartCoroutine(Rotten());

            timeofrot -= Time.deltaTime;

            slider_1.value = timeofrot;
        } if(slider_1.value == 0)
        {
            gameObject.SetActive(false);
            
            Rot += 1;
            cross.countrottensushi(Rot);

        }

        
    }
    IEnumerator Rotten()
    { 
         //int Initialtime = Item.rottenTime;
        Istick = true;
        int rottentimeofShu = Rottingtime;


                yield return new WaitForSeconds(1);
            rottentimeofShu -= 1;
        Debug.Log(rottentimeofShu);
        // Item.rottenTime -= Time.deltaTime;
        slider_1.value = rottentimeofShu;




        if (rottentimeofShu <= 0)
            {
               
                gameObject.SetActive(false);
                rottentimeofShu = 0;
                Rot += 1;
                cross.countrottensushi(Rot);
            }



        Istick = false;
        

    }

   




}
