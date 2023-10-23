using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;


[CreateAssetMenu]
public class Item : ScriptableObject
{
    [SerializeField]
    private string ItemName;
    [SerializeField]
    private GameObject ItemModel;
    [SerializeField]
    private Boolean canrotten;
    [SerializeField]
    private Boolean IsCraftable;
    [SerializeField]
    private Boolean IsCraftOnly;
    [SerializeField]
    private Boolean Isrotten;
    [SerializeField]
    private int rottenTime;
    [SerializeField]
    private int points;
    [SerializeField]
    private int id;

    public bool istoday;

    public string itemName
    {
        get
        {
            return ItemName;
        }
    }
    public GameObject itemModel
    {
        get
        {
            return ItemModel;
        }
    }

    public Boolean Canrotten
    {
        get
        {
            return canrotten;
        }
    }
    public Boolean isCraftable
    {
        get
        {
            return IsCraftable;
        }
    }
    public Boolean isCraftOnly
    {
        get
        {
            return IsCraftOnly;
        }
    }
    public Boolean isrotten
    {
        get
        {
            return Isrotten;
        }
    }
    public int RottenTime
    {
        get
        {
            return rottenTime;
        }
    }
    public int Points
    {
        get
        {
            return points;
        }
    }

    public int Id
    {
        get
        {
            return id;
        }
    }
}











 

 

