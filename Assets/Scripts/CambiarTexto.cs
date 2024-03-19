using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CambiarTexto : MonoBehaviour
{
    public TextMeshProUGUI textoMesh;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void cambiarTexto(string texto)
    {
        textoMesh.text = texto;
    }
}
