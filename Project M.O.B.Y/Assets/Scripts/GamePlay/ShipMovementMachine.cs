using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovementMachine : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    [SerializeField] float rotationSpeed = 200f;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Rotate(int rotation)
    {
        rb.AddTorque(rotation * rotationSpeed * Time.deltaTime);
    }

    public void MoveForward()
    {
        rb.AddForce(transform.up * speed * Time.deltaTime);
    }
}
