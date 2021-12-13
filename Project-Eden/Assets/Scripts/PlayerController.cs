using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController: MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;
    public float sprintSpeed = 20f;
   public AudioSource footSteps;


    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.Space))
        {

        }
        if (Input.GetKey(KeyCode.LeftShift))

        {
            speed = sprintSpeed;


        }
        else

        {
            speed = 12f;

            footSteps.Play();
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 4f;
        }
    }
}


