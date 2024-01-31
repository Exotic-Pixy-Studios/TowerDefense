using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody _rb;

    float _playerSpeed = 5;
    float _horizontalInput;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        //_rb.freezeRotation = true
    }

    // Update is called once per frame
    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");

        if (_horizontalInput != 0)
        {
            _rb.AddForce(new Vector2( _horizontalInput * _playerSpeed,0f));
        }
    }
}
