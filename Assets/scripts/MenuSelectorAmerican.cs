using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSelectorAmerican : MonoBehaviour
{
    public GameObject hamburger;
    public GameObject kfcandchicken;
    public GameObject hotdog;
    public GameObject shrimpgumbo;
    public GameObject reubensandwich;
    public GameObject shrimpsausagejambalaya;

    public int BallSelected;
// Start is called before the first frame update
    void Start()
    {
        hamburger.SetActive (false);
        kfcandchicken.SetActive (false);
        hotdog.SetActive (false);
        shrimpgumbo.SetActive (false);
        reubensandwich.SetActive (false);
        shrimpsausagejambalaya.SetActive (false);
    }
    

    // Update is called once per frame
    public void LoadHamburger()
    {
        hamburger.SetActive (true);
        kfcandchicken.SetActive (false);
        hotdog.SetActive (false);
        shrimpgumbo.SetActive (false);
        reubensandwich.SetActive (false);
        shrimpsausagejambalaya.SetActive (false);
    }

    public void LoadKfc()
    {
        hamburger.SetActive (false);
        kfcandchicken.SetActive (true);
        hotdog.SetActive (false);
        shrimpgumbo.SetActive (false);
        reubensandwich.SetActive (false);
        shrimpsausagejambalaya.SetActive (false);
    }

    public void LoadHotdog()
    {
        hamburger.SetActive (false);
        kfcandchicken.SetActive (false);
        hotdog.SetActive (true);
        shrimpgumbo.SetActive (false);
        reubensandwich.SetActive (false);
        shrimpsausagejambalaya.SetActive (false);
    }

    public void LoadShrimpgumbo()
    {
        hamburger.SetActive (false);
        kfcandchicken.SetActive (false);
        hotdog.SetActive (false);
        shrimpgumbo.SetActive (true);
        reubensandwich.SetActive (false);
        shrimpsausagejambalaya.SetActive (false);
    }

    public void LoadReubensandwich()
    {
        hamburger.SetActive (false);
        kfcandchicken.SetActive (false);
        hotdog.SetActive (false);
        shrimpgumbo.SetActive (false);
        reubensandwich.SetActive (true);
        shrimpsausagejambalaya.SetActive (false);
    }

    public void LoadShrimpsausagejambalaya()
    {
        hamburger.SetActive (false);
        kfcandchicken.SetActive (false);
        hotdog.SetActive (false);
        shrimpgumbo.SetActive (false);
        reubensandwich.SetActive (false);
        shrimpsausagejambalaya.SetActive (true);
    }

}
