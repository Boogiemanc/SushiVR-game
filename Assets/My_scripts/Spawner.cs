using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Item item;

    spawn_item spawnitem;
   


    private void Start()
    {
        spawnitem = spawn_item.Instance;
       



    }
   public void spwan_theobj()
    {
        spawn_item.Instance.SpawnFromPool(item.itemName, transform.position, Quaternion.identity);
        
    }

}
