using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSelectorChinese : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject noodles;
    public GameObject gyoza;
    public GameObject ramen;
    public GameObject sweetandsourchicken;
    

    public int BallSelected;
// Start is called before the first frame update
    void Start()
    {
        noodles.SetActive (false);
        gyoza.SetActive (false);
        ramen.SetActive (false);
        sweetandsourchicken.SetActive (false);
        
    }
    

    // Update is called once per frame
    public void LoadNoodles()
    {
        noodles.SetActive (true);
        gyoza.SetActive (false);
        ramen.SetActive (false);
        sweetandsourchicken.SetActive (false);
       
    }

    public void LoadGyoza()
    {
        noodles.SetActive (false);
        gyoza.SetActive (true);
        ramen.SetActive (false);
        sweetandsourchicken.SetActive (false);
        
    }

    public void LoadRamen()
    {
        noodles.SetActive (false);
        gyoza.SetActive (false);
        ramen.SetActive (true);
        sweetandsourchicken.SetActive (false);
        
    }

    public void LoadSweetandsourchicken()
    {
        noodles.SetActive (false);
        gyoza.SetActive (false);
        ramen.SetActive (false);
        sweetandsourchicken.SetActive (true);
       
    }

    
}
