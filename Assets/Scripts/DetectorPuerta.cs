using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class DetectorPuerta : MonoBehaviour
{
    public GameObject detectorPuerta;
    Collider colosionPuerta;
    public CinemachineBrain camaraCerebro;
    int personajeLayer = 1 << 6;

    private Animator animatorController;
    // Start is called before the first frame update
    void Start()
    {
        animatorController = GetComponent<Animator>();
        colosionPuerta = GetComponent<Collider>();
        //animatorController.Play("Abierta");
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if(Physics.OverlapSphere(transform.position, 2.5f, personajeLayer).Length > 0)
        {
            // Abrir puerta
            //Debug.Log("test");
            if (Input.GetKeyDown(KeyCode.O))
            {
                camaraCerebro.ActiveVirtualCamera.Priority -= 1;
                animatorController.SetBool("abierta", true);
                colosionPuerta.enabled = false;
            }
        }
        /*else
        {
            animatorController.SetBool("abierta", false);
        }*/
    }

    

}
