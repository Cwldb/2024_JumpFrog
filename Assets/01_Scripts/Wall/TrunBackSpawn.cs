using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TrunBackSpawn : MonoBehaviour
{
    private CollisionEagle _collisionEagle;

    private void Awake()
    {
        _collisionEagle = FindAnyObjectByType<CollisionEagle>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _collisionEagle._isCollision = false;
            collision.gameObject.transform.DOMove(new Vector3(0.23f, 1.71f, 0f), 0.2f);
            //collision.gameObject.transform.position = new Vector3(0.23f, 1.71f, 0f);
        }
    }
}
