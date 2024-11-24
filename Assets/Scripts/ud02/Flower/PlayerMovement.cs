using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed = 2f,
                  _turn = 90.0f;

    [SerializeField]
    private float _horizontal,
                  _vertical;

    [SerializeField]
    private Animator _anim;

    [Header("Raycast")]
    public LayerMask GroundMask;

    public float RayLength;

    private Ray _ray;
    private RaycastHit _hit;
    private bool _isGrounded;

    [SerializeField]
    private Rigidbody _rb;

    [SerializeField]
    private float _jumpingForce;

    private void Update()
    {
        InputPlayer();
        Move();
        Rotate();
        AnimationPlayer();
        Jump();

    }

    private void FixedUptade()
    {
        LaunchRaycast();
    }

    private void LaunchRaycast()
    {
        //Punto pivote.
        _ray.origin = transform.position;

        //Hacia abajo.
        _ray.direction = -transform.up;

        if (Physics.Raycast(_ray, out _hit, RayLength))
        {
            _isGrounded = true;
            Debug.Log("Estoy tocando el suelo");

        }

        else 
        { 
            _isGrounded= false;
        
        }

        Debug.DrawRay(_ray.origin, _ray.direction * RayLength, Color.red);
    
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !_isGrounded)
        {
            _rb.AddForce(Vector3.up * _jumpingForce);
        }
    
    }

    private void InputPlayer() 
    {
        _horizontal = Input.GetAxis("Horizontal");

        _vertical = Input.GetAxis("Vertical");
    }

    private void Move()
    {
        transform.Translate(Vector3.forward * _speed * _vertical * Time.deltaTime);

    }
    private void Rotate()
    { 
        transform.Rotate(Vector3.up * _turn * _horizontal * Time.deltaTime);
    }

    private void AnimationPlayer()
    {
        if (_horizontal == 0 && _vertical == 0) 
        {
            _anim.SetBool("IsMoving", false);

        }
        else
        {
            _anim.SetBool("IsMoving", true);
        }

    }
}

