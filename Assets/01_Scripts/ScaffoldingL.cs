using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaffoldingL : MonoBehaviour
{
    private bool _rotateOB = false;
    private Vector3 originalRotation;

    

    private void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && !_rotateOB)
        {
            _rotateOB = true;
            Debug.Log("dd");
            StartCoroutine(RotateObject());
        }
    }

    private void CollisonEnter()
    {
        
    }

    IEnumerator RotateObject()
    {
        yield return new WaitForSeconds(2f);
        Debug.Log("gg");
        transform.rotation = Quaternion.Slerp(Quaternion.identity, Quaternion.Euler(0, 0, -90f), 0.5f);
        yield return new WaitForSeconds(2f);
        Debug.Log("GG");
        _rotateOB = false;
        transform.rotation = Quaternion.Euler(0, 0, 0);


    }

}
