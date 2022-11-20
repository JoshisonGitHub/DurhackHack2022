using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_movement : MonoBehaviour
{
    private Transform camera;
    // Start is called before the first frame update
    void Start()
    {
        camera = transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            //this.position = new Vector3()

            //respawnplayer.transform.position = new Vector3(respawnplayer.transform.position.x, respawnplayer.transform.position.y, respawnplayer.transform.position.z);
        }
    }
}
