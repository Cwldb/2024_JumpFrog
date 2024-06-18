using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exclamationmark : MonoBehaviour
{
    [SerializeField] private GameObject _mark;

    private bool _markCool = false;

    private void Awake()
    {
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!_markCool)
        {
            if (collision.gameObject.CompareTag("SpawnEagle"))
            {
                StartCoroutine(markFalse());
                StartCoroutine(markCoolTime());
            }
        }
    }

    private void Start()
    {
        
    }

    IEnumerator markFalse()
    {
        _mark.gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        _mark.gameObject.SetActive(false);
    }

    IEnumerator markCoolTime()
    {
        _markCool = true;
        yield return new WaitForSeconds(7f);
        _markCool = false;
    }


}
