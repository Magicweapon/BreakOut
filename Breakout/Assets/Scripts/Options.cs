using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Options", menuName = "Tools/Options", order = 1)]
public class Options : PersistentClass
{
    public float ballSpeed;
    public difficulty difficultyLevel = difficulty.facil;

    public enum difficulty
    {
        facil,
        normal,
        dificil
    }

    public void ChangeSpeed(float newSpeed)
    {
        ballSpeed = newSpeed;
    }

    public void ChangeDifficulty(int newDifficulty)
    {
        difficultyLevel = (difficulty)newDifficulty;
    }
}
