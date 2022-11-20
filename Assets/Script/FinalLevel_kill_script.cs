using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalLevel_kill_script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EndGame());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator EndGame()
    {
        yield return new WaitForSeconds(10);
        Application.Quit();
    }
}
