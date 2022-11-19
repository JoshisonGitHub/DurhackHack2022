using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending_script : MonoBehaviour
{
    public GameObject coin;
    private BoxCollider box;
    // Start is called before the first frame update
    void Start()
    {
        box = GetComponent<BoxCollider>();
        box.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        coin = GameObject.FindWithTag("coin");

        if(coin == null)
        {
            box.enabled = true;
        }

        if(box.enabled == true)
        {
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            LoadNextScene();
        }
    }
    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
