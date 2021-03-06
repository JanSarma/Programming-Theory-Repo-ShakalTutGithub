using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Ball : Unit
{




    // POLYMORPHISM
    public override void Jump()
    {

        //Debug.Log("Jump");
        transform.Translate(Vector3.right * Time.deltaTime * speed, Space.World);

        if (transform.position.x > borderGet && speed > 0)
        {
            speed *= -1;
        }
        else if (transform.position.x < -borderGet && speed < 0)
        {
            speed *= -1;
        }

    }

    protected override void Rotate()
    {

    }
}
