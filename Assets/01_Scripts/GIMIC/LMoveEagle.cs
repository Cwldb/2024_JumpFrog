using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LMoveEagle : MonoBehaviour
{
    private Rigidbody2D _rigid;
    [SerializeField] private float _speed = 30f;
    

    private void Awake()
    {
        _rigid = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        _rigid.velocity = new Vector2(1f * _speed, 0);
    }
}
