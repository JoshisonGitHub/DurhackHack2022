using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_damage : MonoBehaviour
{
    private BoxCollider box;
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
            //Destroy(gameObject, .5f);
            Debug.Log("Player Death");
            //Die();
            
        }
        // check for player collision. If true, playerStatusDeath = true
    }

    IEnumerator Die()
    {
        

        
        yield return new WaitForSeconds(2);

#pragma warning disable CS0618 // Type or member is obsolete
        Application.LoadLevel(Application.loadedLevel);
#pragma warning restore CS0618 // Type or member is obsolete

    }
    


}
