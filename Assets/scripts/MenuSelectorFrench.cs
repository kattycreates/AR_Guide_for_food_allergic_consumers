using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSelectorFrench : MonoBehaviour
{
    public GameObject waffles;
    public GameObject rotisseri;
    public GameObject yulelog;
    public GameObject quiche;
    public GameObject galettedesrois;
    public GameObject omelette;
    public GameObject macaron;
    public GameObject salmontartine;

    public int BallSelected;
// Start is called before the first frame update
    void Start()
    {
        waffles.SetActive (false);
        rotisseri.SetActive (false);
        yulelog.SetActive (false);
        quiche.SetActive (false);
        galettedesrois.SetActive (false);
        omelette.SetActive (false);
        macaron.SetActive (false);
        salmontartine.SetActive (false);
    }
    

    // Update is called once per frame
    public void LoadWaffles()
    {
        waffles.SetActive (true);
        rotisseri.SetActive (false);
        yulelog.SetActive (false);
        quiche.SetActive (false);
        galettedesrois.SetActive (false);
        omelette.SetActive (false);
        macaron.SetActive (false);
        salmontartine.SetActive (false);
    }

    public void LoadRotisseri()
    {
        waffles.SetActive (false);
        rotisseri.SetActive (true);
        yulelog.SetActive (false);
        quiche.SetActive (false);
        galettedesrois.SetActive (false);
        omelette.SetActive (false);
        macaron.SetActive (false);
        salmontartine.SetActive (false);
    }

    public void LoadYulelog()
    {
        waffles.SetActive (false);
        rotisseri.SetActive (false);
        yulelog.SetActive (true);
        quiche.SetActive (false);
        galettedesrois.SetActive (false);
        omelette.SetActive (false);
        macaron.SetActive (false);
        salmontartine.SetActive (false);
    }

    public void LoadQuiche()
    {
        waffles.SetActive (false);
        rotisseri.SetActive (false);
        yulelog.SetActive (false);
        quiche.SetActive (true);
        galettedesrois.SetActive (false);
        omelette.SetActive (false);
        macaron.SetActive (false);
        salmontartine.SetActive (false);
    }

    public void LoadGalettedesrois()
    {
        waffles.SetActive (false);
        rotisseri.SetActive (false);
        yulelog.SetActive (false);
        quiche.SetActive (false);
        galettedesrois.SetActive (true);
        omelette.SetActive (false);
        macaron.SetActive (false);
        salmontartine.SetActive (false);
    }

    public void Loadomelette()
    {
        waffles.SetActive (false);
        rotisseri.SetActive (false);
        yulelog.SetActive (false);
        quiche.SetActive (false);
        galettedesrois.SetActive (false);
        omelette.SetActive (true);
        macaron.SetActive (false);
        salmontartine.SetActive (false);
    }
    public void LoadMacaron()
    {
        waffles.SetActive (false);
        rotisseri.SetActive (false);
        yulelog.SetActive (false);
        quiche.SetActive (false);
        galettedesrois.SetActive (false);
        omelette.SetActive (false);
        macaron.SetActive (true);
        salmontartine.SetActive (false);
    }
    public void LoadSalmontartine()
    {
        waffles.SetActive (false);
        rotisseri.SetActive (false);
        yulelog.SetActive (false);
        quiche.SetActive (false);
        galettedesrois.SetActive (false);
        omelette.SetActive (false);
        macaron.SetActive (false);
        salmontartine.SetActive (true);
    }


}
