using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosiveBlock : Block
{
    // Start is called before the first frame update
    void Start()
    {
        resistance = 2;
    }

    public override void BounceBall(Collision collision)
    {
        base.BounceBall(collision);
    }
}
