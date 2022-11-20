using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Camera_movement : MonoBehaviour
{
    

    private player_movement movement;
    // Start is called before the first frame update
    void Start()
    {
       
        movement = GetComponentInParent<player_movement>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Joystick1Button0))
        {
            Debug.Log("button get");
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 4, this.transform.position.z);
            movement.speed = 0;

        }
        

        if(Input.GetKeyUp(KeyCode.Joystick1Button0))
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y-4, this.transform.position.z);
            movement.speed = 4;
        }
    }

    
}
