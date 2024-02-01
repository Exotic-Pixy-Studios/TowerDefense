using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody _rb;

    float _camSpeed = 100f;
    float rotationSpeed = 100.0f;
    float _horizontalInput;
    float _verticalInput;
    bool _lookLeft;
    bool _lookRigth;
    bool _upInput = false;
    bool _downInput = false;
    int aux=0;
    int aux2=0;

    
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
        _lookLeft = Input.GetKey("q");
        _lookRigth = Input.GetKey("e");

        if (_rb.position.y<=20)
        {
            aux=0;
        }else aux=1;
        if (_rb.position.y>=200)
        {
            aux2=0;
        }else aux2=1;

        if (_horizontalInput != 0 || _verticalInput != 0 || _upInput == false || _downInput == false)
        {
            if (_upInput == true)
            {
                _rb.transform.Translate(new Vector3( _horizontalInput * _camSpeed* Time.deltaTime, aux2 * Convert.ToSingle(_upInput) *_camSpeed* Time.deltaTime, _verticalInput * _camSpeed* Time.deltaTime), Space.Self);
            }else{
                _rb.transform.Translate(new Vector3( _horizontalInput * _camSpeed* Time.deltaTime, aux * Convert.ToSingle(_downInput) *_camSpeed*-1* Time.deltaTime, _verticalInput * _camSpeed* Time.deltaTime), Space.Self);
            }

        }
        if (_lookLeft == false || _lookRigth == false)
        {
            if (_lookLeft == true)
            {
                transform.Rotate(new Vector3(0f, Convert.ToSingle(_lookLeft) * rotationSpeed * Time.deltaTime *-1, 0f), Space.Self);

            }else if(_lookRigth == true){
                transform.Rotate(new Vector3(0f, Convert.ToSingle(_lookRigth) * rotationSpeed * Time.deltaTime,0f), Space.Self);
            }
        }

    }   
}



