using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

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
        yield return new WaitForSeconds(0.95f);
        transform.DORotate(new Vector3(0f, 0f, -90f), 0.1f);
        yield return new WaitForSeconds(2f);
        _rotateOB = false;
        transform.DORotate(new Vector3(0f, 0f, 0f), 0.1f);
    }

}
