using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodBlock : Block
{
    // Start is called before the first frame update
    void Start()
    {
        resistance = 3;
    }

    public override void BounceBall(Collision collision)
    {
        base.BounceBall(collision);
    }
}
