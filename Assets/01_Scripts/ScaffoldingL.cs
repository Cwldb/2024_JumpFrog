using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaffoldingL : MonoBehaviour
{
    private bool _rotateOB = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && !_rotateOB)
        {
            _rotateOB = true;
            StartCoroutine(RotateObject());
        }
    }

    IEnumerator RotateObject()
    {
        yield return new WaitForSeconds(1.5f);
        transform.rotation = Quaternion.Euler(0, 0, -90);
        yield return new WaitForSeconds(2f);
        _rotateOB = false;
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }

}
