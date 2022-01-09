using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController: MonoBehaviour
{
    public CharacterController controller;
    public float speed;
    public float walkSpeed;
    public float sprintSpeed = 30f;
    public float run_start;
    bool isRunning;
    float stamina = 5, maxStamina = 5;
    Rect staminaRect;
    Texture2D staminaTexture;
    public AudioSource footsteps;
    bool playAudio;
    public float jump = 0.01f;
    private Vector3 velocity;
    public bool isOnGround = true;
    private float Gravity = -16f;

    void Start()
    {
        staminaRect = new Rect(Screen.width / 10, Screen.height * 9/10, Screen.width / 3, Screen.height / 50);
        staminaTexture = new Texture2D(1, 1);
        staminaTexture.SetPixel(0, 0, Color.white);
        staminaTexture.Apply();
        
    }


    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            SetRunning(true);
            footsteps.Play();

        }
            
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            SetRunning(false);
            speed = 12f;
            footsteps.Stop();
        }
        if (isRunning)
        {
            stamina -= Time.deltaTime; 
            if (stamina < 0)
            {
                stamina = 0;
                SetRunning(false);
                speed = 12f;
                footsteps.Stop();
            }
        }
        else if (stamina < maxStamina)
        {
            stamina += Time.deltaTime;
        }
        //jumping
        if (Input.GetButtonDown("Jump") && transform.position.y < 2.55)
        {
            velocity.y = jump;
            
        }
        else
        {
            velocity.y += Gravity * Time.deltaTime;
        }
        controller.Move(velocity * Time.deltaTime);
    }





    void SetRunning(bool isRunning)
    {
        this.isRunning = isRunning;
        this.speed = isRunning ? sprintSpeed : walkSpeed;
    }
    void OnGUI()
    {
        float ratio = stamina / maxStamina;
        float rectWidth = ratio * Screen.width / 3;
        staminaRect.width = rectWidth;
        GUI.DrawTexture(staminaRect, staminaTexture);
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isOnGround = true;
        }
    }





}



