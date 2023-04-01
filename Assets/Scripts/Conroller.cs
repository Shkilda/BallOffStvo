using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conroller : MonoBehaviour
{
    public float speed = 10f;
    public float stamina = 5000;
    public CharacterController characterController;
    Vector3 move;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Run();
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        move = transform.right * horizontal + transform.forward * vertical;
        characterController.Move(move * speed * Time.deltaTime);

        
    }
    public void Run()
    {
        if (stamina < 5000 && !Input.GetKey(KeyCode.LeftShift))
        {
            stamina += 5;
        }
        if (Input.GetKey(KeyCode.LeftShift) && stamina >  0 )
        {
            stamina -= 5;
            speed = 15f;
            
        }
        else
        {
            speed = 10f;
        }
    }

    
}

