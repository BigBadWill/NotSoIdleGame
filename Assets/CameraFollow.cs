using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform camtarget;
    public float smoothSpeed = 0.125f;
    public float rotatespeed;
    public Vector3 offset;
    private Vector3 velocity = Vector3.zero;

    void LateUpdate()
    {
        //float movHoriz = Input.GetAxis("Mouse X") * rotatespeed;
        //transform.Rotate(0, movHoriz, 0);
        Vector3 desirepos = camtarget.position + offset;
        Vector3 smoothpos = Vector3.SmoothDamp(transform.position, desirepos, ref velocity, smoothSpeed);
        transform.position = smoothpos;
    }
}
