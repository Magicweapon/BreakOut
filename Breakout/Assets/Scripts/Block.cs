using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Block : MonoBehaviour
{
    public int resistance = 1;
    public UnityEvent IncreaseScore;
    public Options options;

    // Start is called before the first frame update
    void Start()
    {
        resistance = (int)(options.difficultyLevel + 1) * resistance;
    }

    // Update is called once per frame
    void Update()
    {
        if (resistance <= 0)
        {
            IncreaseScore.Invoke();
            Destroy(gameObject);
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            BounceBall(collision);
        }
    }

    public virtual void BounceBall(Collision collision)
    {
        Vector3 direction = collision.contacts[0].point - transform.position;
        direction = direction.normalized;
        collision.rigidbody.velocity = collision.gameObject.GetComponent<Ball>().ballSpeed * direction;
        resistance--;
    }
}
