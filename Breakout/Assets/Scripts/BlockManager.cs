using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour
{
    public GameObject nextLevel;
    // Update is called once per frame
    void Update()
    {
        if (transform.childCount == 0)
        {
            nextLevel.SetActive(true);
        }
    }
}
