using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _force;
    [SerializeField] private float _timelife;
    private Rigidbody _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _rb.AddForce(transform.forward * _force);
        Invoke("DestroyMethod", _timelife);
    }

    private void DestroyMethod()
    {
        Destroy(gameObject);
    }
}
