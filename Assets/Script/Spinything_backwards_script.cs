using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinything_backwards_script : MonoBehaviour
{
    private int direction = 1;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ChangeDirection());
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0, direction * 100 * Time.deltaTime, 0);
    }

    IEnumerator ChangeDirection()
    {
        yield return new WaitForSeconds(3);
        direction = -direction;
        StartCoroutine(ChangeDirection());
    }
}
