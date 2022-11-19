using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Android;

public class Coin_script : MonoBehaviour
{
    private SphereCollider sphere;

    private MeshRenderer mesh;
    // Start is called before the first frame update
    void Start()
    {
        sphere= GetComponent<SphereCollider>();
        mesh = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player")){
            Destroy(this.gameObject);
        }
    }
}
