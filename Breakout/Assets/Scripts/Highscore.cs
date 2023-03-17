using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Highscore", menuName = "Tools/Highscore", order = 0)]
public class Highscore : PersistentClass
{
    public int highscore = 1000;
}
