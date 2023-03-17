using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesManager : MonoBehaviour
{
    [HideInInspector] public List<GameObject> lives;
    public GameObject ballPrefab;
    private Ball ballScript;
    public GameObject gameOverMenu;
    
    // Start is called before the first frame update
    void Start()
    {
        //Transform[] children = GetComponentsInChildren<Transform>();

        //foreach (Transform child in children)
        //{
        //    lives.Add(child.gameObject);
        //}

        int i;
        for (i = 0; i < transform.childCount; i++)
        {
            lives.Add(transform.GetChild(i).gameObject);
        }

        Debug.Log("Lives remaining: " + lives.Count);
    }

    public void DeleteLife()
    {
        var objectToDelete = lives[lives.Count - 1];
        Destroy(objectToDelete);
        lives.RemoveAt(lives.Count - 1);

        if (lives.Count == 0)
        {
            gameOverMenu.SetActive(true);
            return;
        }

        var ball = Instantiate(ballPrefab) as GameObject;
        ballScript = ball.GetComponent<Ball>();
        ballScript.OnBallDestroyed.AddListener(this.DeleteLife);

        Debug.Log("Lives remaining: " + lives.Count);
    }
}
