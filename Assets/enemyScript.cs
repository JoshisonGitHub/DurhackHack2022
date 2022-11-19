using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    private SphereCollider sphere;

    // Start is called before the first frame update
    void Start()
    {
        sphere = GetComponent<SphereCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        void OnCollisionEnter(Collision otherObj)
        {
            if (otherObj.gameObject.tag == "Player")
            {
                Destroy(gameObject, .5f);
                Debug.Log("Player Death");
            }
            // check for player collision. If true, playerStatusDeath = true
        }
    }
}