using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSelectorJapanese : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject sushi;
    public GameObject tamago;
    public GameObject yakiudon;
    public GameObject tempura;
    public GameObject yakitori;
    public GameObject sashimi;
    public GameObject onigiri;

    public int BallSelected;
// Start is called before the first frame update
    void Start()
    {
        sushi.SetActive (false);
        tamago.SetActive (false);
        yakiudon.SetActive (false);
        tempura.SetActive (false);
        yakitori.SetActive (false);
        sashimi.SetActive (false);
        onigiri.SetActive (false);
    }
    

    // Update is called once per frame
    public void LoadSushi()
    {
        sushi.SetActive (true);
        tamago.SetActive (false);
        yakiudon.SetActive (false);
        tempura.SetActive (false);
        yakitori.SetActive (false);
        sashimi.SetActive (false);
        onigiri.SetActive (false);
    }

    public void LoadTamago()
    {
        sushi.SetActive (false);
        tamago.SetActive (true);
        yakiudon.SetActive (false);
        tempura.SetActive (false);
        yakitori.SetActive (false);
        sashimi.SetActive (false);
        onigiri.SetActive (false);
    }

    public void LoadYakiudon()
    {
        sushi.SetActive (false);
        tamago.SetActive (false);
        yakiudon.SetActive (true);
        tempura.SetActive (false);
        yakitori.SetActive (false);
        sashimi.SetActive (false);
        onigiri.SetActive (false);
    }

    public void LoadTempura()
    {
        sushi.SetActive (false);
        tamago.SetActive (false);
        yakiudon.SetActive (false);
        tempura.SetActive (true);
        yakitori.SetActive (false);
        sashimi.SetActive (false);
        onigiri.SetActive (false);
    }

    public void LoadYakitori()
    {
        sushi.SetActive (false);
        tamago.SetActive (false);
        yakiudon.SetActive (false);
        tempura.SetActive (false);
        yakitori.SetActive (true);
        sashimi.SetActive (false);
        onigiri.SetActive (false);
    }

    public void LoadSashimi()
    {
        sushi.SetActive (false);
        tamago.SetActive (false);
        yakiudon.SetActive (false);
        tempura.SetActive (false);
        yakitori.SetActive (false);
        sashimi.SetActive (true);
        onigiri.SetActive (false);
    }
    public void LoadOnigiri()
    {
        sushi.SetActive (false);
        tamago.SetActive (false);
        yakiudon.SetActive (false);
        tempura.SetActive (false);
        yakitori.SetActive (false);
        sashimi.SetActive (false);
        onigiri.SetActive (true);
    }

}
