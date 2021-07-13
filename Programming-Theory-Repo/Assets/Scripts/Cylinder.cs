using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Unit
{


    protected override void Rotate()
    {
        transform.Rotate(0f, 0f, 1f);
    }
}
