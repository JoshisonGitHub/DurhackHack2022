using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_damage : MonoBehaviour
{
    public Transform RespawnPlayer;

    private BoxCollider box;

    private bool isdead = false;
    // Start is called before the first frame update
    void Start()
    {
        box = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Enemy"))
        {
            
            Debug.Log("Player Death");
            box.enabled = false;


            isdead = true;
            transform.position = RespawnPlayer.position;
            StartCoroutine(Killplayer());

        }
        // check for player collision. If true, playerStatusDeath = true
    }

    private IEnumerator Killplayer()
    {
        yield return new WaitForSeconds(1);

        //Debug.Log("Respawn");
        
        box.enabled = true;
        isdead = false;
    }
    
    


}
