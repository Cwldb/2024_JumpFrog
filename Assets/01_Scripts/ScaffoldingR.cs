using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaffoldingR : MonoBehaviour
{
    private bool _rotateOB = false;
    private Vector3 originalRotation;

    

    private void Update()
    {
        CollisonEnter();
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
        transform.rotation = Quaternion.Euler(0, 0, 90);
        yield return new WaitForSeconds(3f);
        Debug.Log("GG");
        _rotateOB = false;
        transform.rotation = Quaternion.Euler(0, 0, 0);


    }

}
