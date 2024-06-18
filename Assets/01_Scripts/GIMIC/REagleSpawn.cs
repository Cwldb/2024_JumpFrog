using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class REagleSpawn : MonoBehaviour
{
    [SerializeField] private GameObject _eagleR;
    [SerializeField] private Transform _spawnPoint;

    public bool _isMark { get; set; }

    private bool _spawnCoolTime = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (!_spawnCoolTime)
            {
                _isMark = true;
                Instantiate(_eagleR, _spawnPoint);
                StartCoroutine(SpawnCool());
            }
        }
    }

    private IEnumerator SpawnCool()
    {
        _spawnCoolTime = true;
        yield return new WaitForSeconds(7f);
        _spawnCoolTime = false;
    }
}
