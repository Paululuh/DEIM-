using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class ChickenMove : MonoBehaviour
{

    // Private Variables
    [SerializeField]
    private float _speed = 0.8f,
                  _turnSpeed = 90.0f;

    private float _horizontal,
                  _vertical;


    // Update is called once per frame
    void Update()
    {

        // Movement forward and rear control
        Move();

        // Movement right and left control
        Turn();

    }

    // Method to move the chicken
    private void Move()
    {

        // Teclados W y S & / & /\
        _horizontal = Input.GetAxis("Horizontal");

        transform.Rotate(Vector3.up * _horizontal * _turnSpeed * Time.deltaTime);

    }

    // Method to turn the chicken
    private void Turn()
    {

        // Key control A & D & < & >
        _vertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * _vertical * _speed * Time.deltaTime);

    }
}