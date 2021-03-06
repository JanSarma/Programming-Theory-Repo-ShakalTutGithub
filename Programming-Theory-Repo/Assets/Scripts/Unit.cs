using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Unit : MonoBehaviour
{
    private float border = 4f;
    public float speed = 2f;
    // ENCAPSULATION
    public float borderGet { get { return border; }  set { border = value; } }//hurray it worked

    void Update()
    {
        Jump();
        Rotate();
        
    }

    // ABSTRACTION
    public virtual void Jump()
    {

        //Debug.Log("Jump");
        transform.Translate(Vector3.up * Time.deltaTime * speed, Space.World);

        if (transform.position.y > border && speed>0)
        {   
            speed *=-1;
        }
        else if (transform.position.y < -border&& speed <0)
        {
            speed *= -1;
        }
        
    }

    protected abstract void Rotate();
}
