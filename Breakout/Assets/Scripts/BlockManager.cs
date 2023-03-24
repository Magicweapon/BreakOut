using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour
{
    public GameObject nextLevel;
    void Update()
    {
        if (transform.childCount == 0)
        {
            nextLevel.SetActive(true);
        }
    }
}
