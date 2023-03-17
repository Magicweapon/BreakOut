using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    public int xLimit = 23;
    [SerializeField]
    public float paddleSpeed = 25.0f;
    
    //Vector3 mousePos2D;
    //Vector3 mousePos3D;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //mousePos2D = Input.mousePosition;
        //mousePos2D.z = -Camera.main.transform.position.z;
        //mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);

        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    transform.Translate(Vector3.down * paddleSpeed * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    transform.Translate(Vector3.up * paddleSpeed * Time.deltaTime);
        //}

        transform.Translate(Input.GetAxisRaw("Horizontal") * Vector3.down * paddleSpeed * Time.deltaTime);

        Vector3 pos = transform.position;

        if (pos.x < -xLimit)
        {
            pos.x = -xLimit;
        }
        else if (pos.x > xLimit)
        {
            pos.x = xLimit;
        }

        transform.position = pos;
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Vector3 direction = collision.contacts[0].point - transform.position;
            direction = direction.normalized;
            collision.rigidbody.velocity = collision.gameObject.GetComponent<Ball>().ballSpeed * direction;
        }
    }
}