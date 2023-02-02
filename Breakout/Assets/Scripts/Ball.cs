using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private bool isGameStarted = false;

    [SerializeField]
    public float ballSpeed = 10.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        Vector3 initPos = GameObject.FindGameObjectWithTag("Player").transform.position;
        initPos.y += 3;

        transform.position = initPos;
        transform.SetParent(GameObject.FindGameObjectWithTag("Player").transform);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Submit"))
        {
            if (!isGameStarted)
            {
                isGameStarted = true;
                transform.SetParent(null);
                GetComponent<Rigidbody>().velocity = Vector3.up * ballSpeed;
            }
        }
    }
}
