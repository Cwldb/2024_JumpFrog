using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TrunBackSpawn : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.DOMove(new Vector3(0.23f, 1.71f, 0f), 0.2f);
            //collision.gameObject.transform.position = new Vector3(0.23f, 1.71f, 0f);
        }

        if (collision.gameObject.CompareTag("LEagle") || collision.gameObject.CompareTag("REagle"))
        {
            Destroy(collision.gameObject);
        }

        
;
    }
}
