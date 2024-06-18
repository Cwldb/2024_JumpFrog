using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class RMoveEagle : MonoBehaviour
{
    private Rigidbody2D _rigid;
    [SerializeField] private float _speed = 30f;

    private void Awake()
    {
        _rigid = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        StartCoroutine(DestroyEagle());
    }
    // Update is called once per frame
    void Update()
    {
        _rigid.velocity = new Vector2(-1f * _speed, 0);
    }

    IEnumerator DestroyEagle()
    {
        yield return new WaitForSeconds(4f);
        Destroy(gameObject);
    }
}
