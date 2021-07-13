using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Unit : MonoBehaviour
{
    public float border = 4f;
    public float speed = 2f;

    void Update()
    {
        Jump();
        Rotate();
        
    }

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
