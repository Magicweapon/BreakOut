using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DifficultyDropdown : MonoBehaviour
{
    public Options options;
    private Dropdown difficulty;

    private void Start()
    {
        difficulty = GetComponent<Dropdown>();
        difficulty.onValueChanged.AddListener(delegate { options.ChangeDifficulty(difficulty.value); });
    }
}
