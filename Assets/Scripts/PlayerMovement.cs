using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb { get; set; } = null;

    private Transform playerTransform { get; set; } = null;

    public float _playerSpeed = 2;
    public float playerSpeed { get { return _playerSpeed; } set { _playerSpeed = value; } }

    private Vector3 direction { get; set; } = Vector3.zero;

    private void Start()
    {
        playerTransform = transform;
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        direction = Vector3.zero;

        if (Input.GetButton("Vertical"))
        {
            direction += playerTransform.forward * Time.deltaTime * playerSpeed * Input.GetAxis("Vertical");
        }
        if(Input.GetButton("Horizontal"))
        {
            direction += playerTransform.right * Time.deltaTime * playerSpeed * Input.GetAxis("Horizontal");
        }
    }

    private void FixedUpdate()
    {
        rb.position += direction;
    }
}
