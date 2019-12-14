using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody thebody;

    void Start()
    {
        thebody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float MoveHoriz = Input.GetAxis("Horizontal") * 5f;
        float MoveVert = Input.GetAxis("Vertical") * 5f;
        float HorizRot = Input.GetAxis("Mouse X") * 5f;
        thebody.AddRelativeForce(MoveHoriz, 0.0f, MoveVert);
        transform.Rotate(0, HorizRot, 0);
    }
}
