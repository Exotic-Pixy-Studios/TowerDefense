using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody _rb;

    float _playerSpeed = 5f;
    float _horizontalInput;
    float _verticalInput;
    bool _upInput = false;
    bool _downInput = false;
    
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
        _upInput = Input.GetKey("space");
        _downInput = Input.GetKey("tab");


        if (_horizontalInput != 0 || _verticalInput != 0 || _upInput == false || _downInput == false)
        {
            if (_upInput == true)
            {
                _rb.AddForce(new Vector3( _horizontalInput * _playerSpeed, Convert.ToSingle(_upInput) *_playerSpeed, _verticalInput * _playerSpeed));
            }else{
                _rb.AddForce(new Vector3( _horizontalInput * _playerSpeed, Convert.ToSingle(_downInput) *_playerSpeed*-1, _verticalInput * _playerSpeed));
            }

        }

    }   
}
