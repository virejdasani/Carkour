using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltController : MonoBehaviour
{
    public int tiltForce = 1;

    private Rigidbody rigid;

    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Get the tilt (xyz) and assign it to tilt
        Vector3 tilt = Input.acceleration;

        // If the horizontal is not tilted, nothing happens
        if (tilt.x == 0)
            Debug.Log("zero");

        // If the tilt is positive, then add a positive force to the x
        else if (tilt.x > 0)
        {
            rigid.AddForce(new Vector3(tiltForce, 0, 0));
            //Debug.Log("positive");
        }

        // If the tilt is negative, then add a negative force to the x
        else
        {
            rigid.AddForce(new Vector3(-tiltForce, 0, 0));
            //Debug.Log("negative");
        }
    }
}
