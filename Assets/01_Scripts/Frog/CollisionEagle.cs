using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEagle : MonoBehaviour
{
    private Rigidbody2D _rigid;
    private LEagleSpawn _lEagle;
    private REagleSpawn _rEagle;

    [SerializeField] private float _power = 20f;

    public bool _isCollision {  get; set; }

    private void Awake()
    {
        _lEagle = FindAnyObjectByType<LEagleSpawn>();
        _rEagle = FindAnyObjectByType<REagleSpawn>();
        _rigid = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("LEagle"))
        {
            _isCollision = true;
            _rigid.AddForce(Vector2.right * _power, ForceMode2D.Impulse);
            StartCoroutine(Collision());
        }
        else if (collision.gameObject.CompareTag("REagle"))
        {
            _isCollision = true;
            _rigid.AddForce(Vector2.left * _power, ForceMode2D.Impulse);
            StartCoroutine(Collision());
        }
    }

    private IEnumerator Collision()
    {
        yield return new WaitForSeconds(1.5f);
        _isCollision = false;
    }


}
