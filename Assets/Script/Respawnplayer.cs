using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawnplayer : MonoBehaviour
{
    public GameObject respawnplayer;

    private CapsuleCollider cap;
    // Start is called before the first frame update
    void Start()
    {
        cap = GetComponent<CapsuleCollider>();
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
            cap.enabled = false;
        }
    }
}
