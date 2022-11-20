using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawnplayer : MonoBehaviour
{
    public GameObject respawnplayer;

    
    private SphereCollider sphere;

    public bool insafezone = false;
    // Start is called before the first frame update
    void Start()
    {
        
        respawnplayer = GameObject.FindWithTag("respawner");
        sphere = GetComponent<SphereCollider>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            insafezone = true;
            //Debug.Log("next");
            respawnplayer.transform.position = this.transform.position;
            respawnplayer.transform.position = new Vector3(respawnplayer.transform.position.x, respawnplayer.transform.position.y+1, respawnplayer.transform.position.z);
            sphere.enabled = false;
        }
        else
        {
            insafezone = false;
        }
    }
}
