using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class italiantest : MonoBehaviour
{
    public GameObject lasagna;
    public GameObject calzone;
    public GameObject ravioli;
    public GameObject zeppole;
    public GameObject pizza;
    public GameObject Alasagna;
    public GameObject Acalzone;
    public GameObject Aravioli;
    public GameObject Azeppole;
    public GameObject Apizza;
    public GameObject Ilasagna;
    public GameObject Icalzone;
    public GameObject Iravioli;
    public GameObject Izeppole;
    public GameObject Ipizza;
    public GameObject Hlasagna;
    public GameObject Hcalzone;
    public GameObject Hravioli;
    public GameObject Hzeppole;
    public GameObject Hpizza;
    public GameObject Rlasagna;
    public GameObject Rcalzone;
    public GameObject Rravioli;
    public GameObject Rzeppole;
    public GameObject Rpizza;
   
    public int BallSelected;
// Start is called before the first frame update
    void Start()
    {
        Alasagna.SetActive (false);
        Acalzone.SetActive (false);
        Aravioli.SetActive (false);
        Azeppole.SetActive (false);
        Apizza.SetActive (false);
        Ilasagna.SetActive (false);
        Icalzone.SetActive (false);
        Iravioli.SetActive (false);
        Izeppole.SetActive (false);
        Ipizza.SetActive (false);
        Hlasagna.SetActive (false);
        Hcalzone.SetActive (false);
        Hravioli.SetActive (false);
        Hzeppole.SetActive (false);
        Hpizza.SetActive (false);
        Rlasagna.SetActive (false);
        Rcalzone.SetActive (false);
        Rravioli.SetActive (false);
        Rzeppole.SetActive (false);
        Rpizza.SetActive (false);
        
    }
    

    // Update is called once per frame
    public void LoadAllergeninfo()
    {
        if(lasagna.activeSelf)
        {
            Alasagna.SetActive (true);
            Acalzone.SetActive (false);
            Aravioli.SetActive (false);
            Azeppole.SetActive (false);
            Apizza.SetActive (false);
        }
        else if(calzone.activeSelf)
        {
            Alasagna.SetActive (false);
            Acalzone.SetActive (true);
            Aravioli.SetActive (false);
            Azeppole.SetActive (false);
            Apizza.SetActive (false);
        }
        else if(ravioli.activeSelf)
        {
            Alasagna.SetActive (false);
            Acalzone.SetActive (false);
            Aravioli.SetActive (true);
            Azeppole.SetActive (false);
            Apizza.SetActive (false);
        }
        else if(zeppole.activeSelf)
        {
            Alasagna.SetActive (false);
            Acalzone.SetActive (false);
            Aravioli.SetActive (false);
            Azeppole.SetActive (true);
            Apizza.SetActive (false);
        }
        else if(pizza.activeSelf)
        {
            Alasagna.SetActive (false);
            Acalzone.SetActive (false);
            Aravioli.SetActive (false);
            Azeppole.SetActive (false);
            Apizza.SetActive (true);
        }
        else
        {}
        

        
    }

    public void LoadIngredientsinfo()
    {
        if(lasagna.activeSelf)
        {
            Ilasagna.SetActive (true);
            Icalzone.SetActive (false);
            Iravioli.SetActive (false);
            Izeppole.SetActive (false);
            Ipizza.SetActive (false);
        }
        else if(calzone.activeSelf)
        {
            Ilasagna.SetActive (false);
            Icalzone.SetActive (true);
            Iravioli.SetActive (false);
            Izeppole.SetActive (false);
            Ipizza.SetActive (false);
        }
        else if(ravioli.activeSelf)
        {
            Ilasagna.SetActive (false);
            Icalzone.SetActive (false);
            Iravioli.SetActive (true);
            Izeppole.SetActive (false);
            Ipizza.SetActive (false);
        }
        else if(zeppole.activeSelf)
        {
            Ilasagna.SetActive (false);
            Icalzone.SetActive (false);
            Iravioli.SetActive (false);
            Izeppole.SetActive (true);
            Ipizza.SetActive (false);
        }
        else if(pizza.activeSelf)
        {
            Ilasagna.SetActive (false);
            Icalzone.SetActive (false);
            Iravioli.SetActive (false);
            Izeppole.SetActive (false);
            Ipizza.SetActive (true);
        }
        else
        {}
    }

    public void LoadHealthtipinfo()
    {
        if(lasagna.activeSelf)
        {
            Hlasagna.SetActive (true);
            Hcalzone.SetActive (false);
            Hravioli.SetActive (false);
            Hzeppole.SetActive (false);
            Hpizza.SetActive (false);
        }
        else if(calzone.activeSelf)
        {
            Hlasagna.SetActive (false);
            Hcalzone.SetActive (true);
            Hravioli.SetActive (false);
            Hzeppole.SetActive (false);
            Hpizza.SetActive (false);
        }
        else if(ravioli.activeSelf)
        {
            Hlasagna.SetActive (false);
            Hcalzone.SetActive (false);
            Hravioli.SetActive (true);
            Hzeppole.SetActive (false);
            Hpizza.SetActive (false);
        }
        else if(zeppole.activeSelf)
        {
            Hlasagna.SetActive (false);
            Hcalzone.SetActive (false);
            Hravioli.SetActive (false);
            Hzeppole.SetActive (true);
            Hpizza.SetActive (false);
        }
        else if(pizza.activeSelf)
        {
            Hlasagna.SetActive (false);
            Hcalzone.SetActive (false);
            Hravioli.SetActive (false);
            Hzeppole.SetActive (false);
            Hpizza.SetActive (true);
        }
        else
        {}
    }

    public void LoadRecipe()
    {
       if(lasagna.activeSelf)
        {
            Rlasagna.SetActive (true);
            Rcalzone.SetActive (false);
            Rravioli.SetActive (false);
            Rzeppole.SetActive (false);
            Rpizza.SetActive (false);
        }
        else if(calzone.activeSelf)
        {
            Rlasagna.SetActive (false);
            Rcalzone.SetActive (true);
            Rravioli.SetActive (false);
            Rzeppole.SetActive (false);
            Rpizza.SetActive (false);
        }
        else if(ravioli.activeSelf)
        {
            Rlasagna.SetActive (false);
            Rcalzone.SetActive (false);
            Rravioli.SetActive (true);
            Rzeppole.SetActive (false);
            Rpizza.SetActive (false);
        }
        else if(zeppole.activeSelf)
        {
            Rlasagna.SetActive (false);
            Rcalzone.SetActive (false);
            Rravioli.SetActive (false);
            Rzeppole.SetActive (true);
            Rpizza.SetActive (false);
        }
        else if(pizza.activeSelf)
        {
            Rlasagna.SetActive (false);
            Rcalzone.SetActive (false);
            Rravioli.SetActive (false);
            Rzeppole.SetActive (false);
            Rpizza.SetActive (true);
        }
        else
        {}
    }

   

   
}



