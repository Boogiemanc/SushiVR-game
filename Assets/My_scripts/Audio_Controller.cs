using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_Controller : MonoBehaviour
   
{
    public static Audio_Controller instance;
    public AudioSource cuttingfish, chopping, makerice, placesushi, correct, wrong, holdsushi, holdItem, materialdrop, knifehitwood, knifehitdrop, metalhit, buttonselect, countdown;
    // Start is called before the first frame updatesushidrop
    void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playcuttingfish()
    {
        cuttingfish.Stop();
        cuttingfish.Play();
    }
    public void playchopping()
    {
        chopping.Stop();
        chopping.Play();
    }

    public void playcmakerice()
    {
        makerice.Stop();
        makerice.Play();
    }

    public void playplacesushi()
    {
        placesushi.Stop();
        placesushi.Play();
    }

    public void playcorrect()
    {
        correct.Stop();
        correct.Play();
    }

    public void playwrong()
    {
        wrong.Stop();
        wrong.Play();
    }

    public void playholdsushi()
    {
        holdsushi.Stop();
        holdsushi.Play();
    }

    public void playholdItem()
    {
        holdItem.Stop();
        holdItem.Play();
    }

   
    public void playmaterialdrop()
    {
        materialdrop.Stop();
        materialdrop.Play();
    }

    public void playknifehitwood()
    {
        knifehitwood.Stop();
        knifehitwood.Play();
    }
    public void playknifehitdrop()
    {
        knifehitdrop.Stop();
        knifehitdrop.Play();
    }


    public void playmetalhit()
    {
        knifehitdrop.Stop();
        knifehitdrop.Play();
    }

    public void playbuttonselect()
    {
        buttonselect.Stop();
        buttonselect.Play();
    }

    public void playcountdown()
    {
        countdown.Stop();
        countdown.Play();
    }
} 
