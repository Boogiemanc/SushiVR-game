using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Crafting_check : MonoBehaviour
{
    
    Item item;
    spawn_item spawnitem;
    public List<Crafting> crafting;
    public GameObject ResultgSpace;
   public List<GameObject> materials;

    //   public GameObject DetectgSpaceB;
    //   public GameObject DetectgSpaceA;
    public static Crafting_check Instance;
     


    void Awake()
    {
        spawnitem = spawn_item.Instance;
        List<GameObject> materials = new List<GameObject>(2);
        List<Crafting> crafting = new List<Crafting>();

    }
    private void Update()
    { if(materials.Count == 2)
        {
            checkmaterialorder(materials);
            materials.Clear();
        }
       
    }

    public void checkmaterialorder(List<GameObject> materialstructure)
    {

        Item[] itemsushiextract = new Item[materialstructure.Count];
        int[] materialcheckId1 = new int[materialstructure.Count];
        for (int i = 0; i < materialstructure.Count; i++)
        {
            int materialname = materialstructure[i].GetComponent<sushiMaterial>().item.Id;
            itemsushiextract[i] = materialstructure[i].GetComponent<sushiMaterial>().item;
            materialcheckId1[i] = materialstructure[i].GetComponent<sushiMaterial>().item.Id;
            // Debug.Log("test" + materialname);
            // Debug.Log(itemsushiextract[i].itemName);


        }
        SEArching(materialcheckId1[0], materialcheckId1[1]);
        materials[0].SetActive(false);
        materials[1].SetActive(false);





    }

    public void SEArching(int A, int B)
    {

        Item[] holder = new Item[2];
        int TargetItemA;
        int TargetItemB;

        Item CombineItemC;
        bool Isfound = false;
        GameObject combined;
        int i = 0;

        Debug.Log("test");
        while (i < crafting.Count && Isfound == false)
        {
            for (int j = 0; j < 2; j++)
            {
                foreach (Crafting targetrecipe in crafting) ;
                holder[j] = crafting[i].Materials[j];
            }

            TargetItemA = holder[0].Id;
            TargetItemB = holder[1].Id;

            if (TargetItemA == A && TargetItemB == B)
            {
                CombineItemC = crafting[i].Results[0];

                combined = CombineItemC.itemModel;
                Isfound = true;
                Debug.Log("This is a match! variant A" + CombineItemC.itemName);
                spawn_item.Instance.SpawnFromPool(CombineItemC.itemName, ResultgSpace.transform.position, Quaternion.identity);
                Audio_Controller.instance.playholdsushi();
                   
            }
            else if (TargetItemA == B && TargetItemB == A)
            {

                CombineItemC = crafting[i].Results[0];

                combined = CombineItemC.itemModel;
                Isfound = true;

                Debug.Log("This is a match! variant B");
                spawn_item.Instance.SpawnFromPool(CombineItemC.itemName, transform.position, Quaternion.identity);
            }
            else
            {
                Debug.Log("No Match in " + crafting[i].name);
            }
            i++;
        }


    }
    private void OnTriggerEnter(Collider rawmaterials)
    {
        
       // int addlocation = 0;

        if (  rawmaterials != null)
        {
            if (rawmaterials.gameObject.tag == ("material"))
            {
                GameObject inputmaterial = rawmaterials.gameObject;
                materials.Add (inputmaterial);
                // materials.Insert(addlocation, inputmaterial);
               // addlocation += 1;


            }
        }
        else
        {
            Debug.Log("raw materials detection failed!");
        }
    }

    /*  public void InsertyToList(GameObject DetectedTarget)
       { 
           int currenttrack = 0;
           if (DetectedTarget != null)
           {
               materials[currenttrack] = DetectedTarget;
               currenttrack++;
           }
           else { Debug.Log("raw materials detection failed!"); }


       } */
   


}
     
