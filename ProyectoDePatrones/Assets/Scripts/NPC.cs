using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{

    public GameObject PanelNPC;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("ActivarPanel", 1f);
    }

    // Update is called once per frame
    void ActivarPanel()
    {
        PanelNPC.SetActive(true);
    }

    public void BotonSalir()
    {
        PanelNPC.SetActive(false);
    }
}
