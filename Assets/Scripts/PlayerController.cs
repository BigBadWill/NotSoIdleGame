using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody myhotsexybody;
    //private Quaternion desireRot;
    //public Transform campos;

    public float speed;
    
    void Start()
    {
        myhotsexybody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float HorizMov = Input.GetAxis("Horizontal");
        float VertMov = Input.GetAxis("Vertical");
        float HorizRot = Input.GetAxis("Mouse X") * 5f;

        //Vector3 asdf = campos.transform.eulerAngles;
        //desireRot.eulerAngles = Quaternion.Euler(campos.transform.eulerAngles);

        Vector3 movement = new Vector3(HorizMov, 0.0f, VertMov);

        myhotsexybody.AddRelativeForce(movement * speed);
        transform.Rotate(0, HorizRot, 0);
    }
}
