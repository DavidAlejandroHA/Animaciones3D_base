using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MostrarPaneles : MonoBehaviour
{
    public GameObject panelTexto;
    public TextMeshProUGUI texto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void activarPanelTexto()
    {
        panelTexto.SetActive(true);
    }
}
