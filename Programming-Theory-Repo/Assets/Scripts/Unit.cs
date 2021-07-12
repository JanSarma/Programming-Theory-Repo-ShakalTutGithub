using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public float border = 4f;
    public float speed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
    }

    void Jump()
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
        
        /*
        else if (transform.position.y < -border)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed, Space.World);
        }
        */

    }
}
