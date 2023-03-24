using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Ball : MonoBehaviour
{
    private bool isGameStarted = false;
    private Vector3 lastPosition = Vector3.zero;
    private Vector3 direction = Vector3.zero;
    private new Rigidbody rigidbody;
    private BorderManagement borderManagement;
    public UnityEvent OnBallDestroyed;
    public Options options;

    [SerializeField]
    public float ballSpeed;
    
    void Awake()
    {
        borderManagement = GetComponent<BorderManagement>();
        ballSpeed = options.ballSpeed;
    }

    void Start()
    {
        isGameStarted = false;
        Vector3 initPos = GameObject.FindGameObjectWithTag("Player").transform.position;
        initPos.y += 2;

        transform.position = initPos;
        transform.SetParent(GameObject.FindGameObjectWithTag("Player").transform);
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (borderManagement.outDown)
        {
            OnBallDestroyed.Invoke();
            Destroy(this.gameObject);
        }
        if (borderManagement.outUp)
        {
            direction = transform.position - lastPosition;
            direction.y *= -1;
            direction = direction.normalized;
            rigidbody.velocity = ballSpeed * direction;
        }
        if (borderManagement.outLeft)
        {
            direction = transform.position - lastPosition;
            direction.x *= -1;
            direction = direction.normalized;
            rigidbody.velocity = ballSpeed * direction;
        }
        if (borderManagement.outRight)
        {
            direction = transform.position - lastPosition;
            direction.x *= -1;
            direction = direction.normalized;
            rigidbody.velocity = ballSpeed * direction;
        }

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

    private void FixedUpdate()
    {
        lastPosition = transform.position;
    }

    private void LateUpdate()
    {
        if (direction != Vector3.zero) direction = Vector3.zero;
    }
}
