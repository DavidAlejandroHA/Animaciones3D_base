using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public float speed; // La velocidad a la que se va a mover el personaje
    public float turnSpeed = 300.0f; // La velocidad de giro
    private float originalSpeed;

    private CharacterController characterController;
    private Animator animatorController;

    void Start()
    {

        characterController = GetComponent<CharacterController>();
        animatorController = GetComponent<Animator>();
        originalSpeed = speed;
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Controlando si intenta correr
        if (Input.GetKey(KeyCode.R))
        {
            speed = originalSpeed + 1.5f;
        }
        else
        {
            speed = originalSpeed;

        }
        // Rotamos en el eje Y
        transform.Rotate(0, horizontal * turnSpeed * Time.deltaTime, 0);

        // Nos movemos usando el characterController
        Vector3 move = transform.forward * vertical;
        characterController.Move(move * speed * Time.deltaTime);


        // TODO: Establecer las transiciones.
        //animatorController.SetFloat("Velocidad", move.z);
        //animatorController.SetFloat("Velocidad", vertical);
        animatorController.SetFloat("Velocidad", characterController.velocity.z);

        
    }
   }
