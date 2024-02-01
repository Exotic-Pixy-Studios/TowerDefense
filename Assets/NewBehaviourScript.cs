using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody _rb;

    float _playerSpeed = 1.5f;
    float _horizontalInput;
    float _verticalInput;
    float altura;
    bool alturaBool = false;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        //_rb.freezeRotation = true
    }

    // Update is called once per frame
    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");
        alturaBool = Input.GetKey("space");

        if (_horizontalInput != 0 || _verticalInput != 0 || altura == 0)
        {
            _rb.AddForce(new Vector3(_horizontalInput * _playerSpeed, Convert.ToSingle(alturaBool) * _playerSpeed, _verticalInput * _playerSpeed));
        }
    }
}
