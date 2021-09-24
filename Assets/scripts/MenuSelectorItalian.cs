using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSelectorItalian : MonoBehaviour
{
    public GameObject lasagna;
    public GameObject calzone;
    public GameObject ravioli;
    public GameObject zeppole;
    public GameObject pizza;
   
    public int BallSelected;
// Start is called before the first frame update
    void Start()
    {
        lasagna.SetActive (false);
        calzone.SetActive (false);
        ravioli.SetActive (false);
        zeppole.SetActive (false);
        pizza.SetActive (false);
        
    }
    

    // Update is called once per frame
    public void LoadLasagna()
    {
        lasagna.SetActive (true);
        calzone.SetActive (false);
        ravioli.SetActive (false);
        zeppole.SetActive (false);
        pizza.SetActive (false);
    }

    public void LoadCalzone()
    {
        lasagna.SetActive (false);
        calzone.SetActive (true);
        ravioli.SetActive (false);
        zeppole.SetActive (false);
        pizza.SetActive (false);
    }

    public void LoadRavioli()
    {
        lasagna.SetActive (false);
        calzone.SetActive (false);
        ravioli.SetActive (true);
        zeppole.SetActive (false);
        pizza.SetActive (false);
    }

    public void LoadZeppole()
    {
        lasagna.SetActive (false);
        calzone.SetActive (false);
        ravioli.SetActive (false);
        zeppole.SetActive (true);
        pizza.SetActive (false);
    }

    public void LoadPizza()
    {
        lasagna.SetActive (false);
        calzone.SetActive (false);
        ravioli.SetActive (false);
        zeppole.SetActive (false);
        pizza.SetActive (true);
    }

   
}
