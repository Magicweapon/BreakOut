using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneBlock : Block
{
    // Start is called before the first frame update
    void Start()
    {
        resistance = 3;
        resistance = (int)((float)options.difficultyLevel + 0.4f) * resistance;
    }

    public override void BounceBall(Collision collision)
    {
        base.BounceBall(collision);
    }
}
