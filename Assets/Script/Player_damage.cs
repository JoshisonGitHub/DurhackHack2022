using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_damage : MonoBehaviour
{
    public Transform RespawnPlayer;

    private CharacterController controller;

    private bool isdead = false;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        
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
            controller.enabled= false;


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
        
        controller.enabled = true;
        isdead = false;
    }
    
    


}