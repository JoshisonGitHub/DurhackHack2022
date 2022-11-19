using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    private SphereCollider sphere;

    // Start is called before the first frame update
    void Start()
    {
        sphere = gameObject.GetComponent<SphereCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals( "Player"))
        {
            //Destroy(gameObject, .5f);
            Debug.Log("Player Death");
        }
        // check for player collision. If true, playerStatusDeath = true
    }

  
}