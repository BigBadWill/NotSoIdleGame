using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float MoveHoriz = Input.GetAxis("Horizontal");
        float MoveVert = Input.GetAxis("Vertical");
        transform.Translate(MoveHoriz,0.0f, MoveVert);
    }
}
