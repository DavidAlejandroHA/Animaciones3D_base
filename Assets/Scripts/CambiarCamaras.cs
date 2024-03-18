using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CambiarCamaras : MonoBehaviour
{
    public CinemachineVirtualCamera camaraCambio;
    public CinemachineBrain camaraCerebro;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Personaje"))
        {
            camaraCerebro.ActiveVirtualCamera.Priority -= 1;
            //camaraCambio.GetComponent<CinemachineVirtualCamera>();
            camaraCambio.Priority += 1;
        }
    }
}
