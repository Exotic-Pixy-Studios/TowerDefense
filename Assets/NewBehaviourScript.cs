using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody _rb;

    float _playerSpeed = 5f;
    float _horizontalInput;
    void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _horizontalInput = Input.GetAxisRaw("horizontal");

        if (_horizontalInput != 0){
            _rb.AddForce(new Vector3(0f, _horizontalInput * _playerSpeed, 0f));
        }
    }
}