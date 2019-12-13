using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody myhotsexybody;

    public float speed;
    
    void Start()
    {
        myhotsexybody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float HorizMov = Input.GetAxis("Horizontal");
        float VertMov = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(HorizMov, 0.0f, VertMov);

        myhotsexybody.AddForce(movement * speed);
    }
}
