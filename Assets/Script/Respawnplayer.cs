using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawnplayer : MonoBehaviour
{
    public GameObject respawnplayer;

    private BoxCollider box;
    // Start is called before the first frame update
    void Start()
    {
        box = GetComponent<BoxCollider>();
        respawnplayer = GameObject.FindWithTag("respawner");

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            Debug.Log("next");
            respawnplayer.transform.position = this.transform.position;
            respawnplayer.transform.position = new Vector3(respawnplayer.transform.position.x, respawnplayer.transform.position.y + 2, respawnplayer.transform.position.z);
            box.enabled = false;
        }
    }
}
