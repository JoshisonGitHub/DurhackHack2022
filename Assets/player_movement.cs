using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public CharacterController controller;
    public float speed;


    public KeyCode forwards;
    public KeyCode backwards;
    public KeyCode left;
    public KeyCode right;

    

    private static float g = -1f;
    private Vector3[] inputs = new Vector3[4];
    private Vector3 moveinput;

    private bool isdead = false;

    private MeshRenderer mesh;
    // Start is called before the first frame update
    void Start()
    {
        inputs[0] = new Vector3(-1, g, 0);
        inputs[1] = new Vector3(1, g, 0);
        inputs[2] = new Vector3(0, g, 1);
        inputs[3] = new Vector3(0, g, -1);

        mesh = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
            if (Input.GetKey(left))
            {
                moveinput = inputs[0];
            }
            else if (Input.GetKey(right))
            {
                moveinput = inputs[1];
            }
            else if (Input.GetKey(forwards))
            {
                moveinput = inputs[2];
            }
            else if (Input.GetKey(backwards))
            {
                moveinput = inputs[3];
            }
            else
            {
                moveinput = new Vector3(0, g, 0);
            }
        
        
        if (!isdead)
        {
            controller.Move(moveinput * speed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            inputs[0] = new Vector3(-1, g, 0);
            inputs[1] = new Vector3(1, g, 0);
            inputs[2] = new Vector3(0, g, 1);
            inputs[3] = new Vector3(0, g, -1);
        }
    }
}
