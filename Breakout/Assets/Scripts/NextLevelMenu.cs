using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelMenu : MonoBehaviour
{
    public void NextLevel()
    {
        var nextLevel = SceneManager.GetActiveScene().buildIndex + 1;
        if (SceneManager.sceneCount > nextLevel)
        {
            SceneManager.LoadScene(nextLevel);
        }
        else
        {
            GotoMainScreen();
        }
    }

    public void GotoMainScreen()
    {
        SceneManager.LoadScene(0);
    }

    public void RetryLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
