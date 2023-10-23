using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Count_down : MonoBehaviour
{
    
    public GameObject textDisplay;
    public int secondsleft;
    public int minutesleft ;
    public bool takingAway = false;
    bool Isplaying = true;

    // Start is called before the first frame update
    void Start()
    {
        textDisplay.GetComponent<Text>().text = "0" + minutesleft + ":" + secondsleft;
    }

    // Update is called once per frame
    void Update()
    {
        if(takingAway == false && secondsleft > 0 && Isplaying)
        {
            StartCoroutine(TimerTake());
        }

        if (minutesleft < 0 && secondsleft < 0 )
        {
           
            Isplaying = false;
              minutesleft = 0;
            secondsleft = 0;
            TimesUp();
        }
    }

    IEnumerator TimerTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsleft -= 1;
        textDisplay.GetComponent<Text>().text = "0" + minutesleft +":"+ secondsleft;
        if (secondsleft < 10)
        {
            textDisplay.GetComponent<Text>().text = "0" + minutesleft + ":" + "0"+ secondsleft;
            
            if (secondsleft <= 0 && minutesleft >= 0)
            {
                secondsleft = 60;
                minutesleft -= 1;

            }
        }

        if (minutesleft == -1)
        {
            //Debug.Log("time's up !");
            Isplaying = false;
            minutesleft = 0;
            secondsleft = 0;
            TimesUp();
        }
        takingAway = false;





    }

    void TimesUp()
    {
        SceneManager.LoadScene(2);

    }




}
