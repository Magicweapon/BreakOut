using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetHighscoresButton : MonoBehaviour
{
    public Options options;
    private Button resetHighscore;

    private void Start()
    {
        resetHighscore = GetComponent<Button>();
        resetHighscore.onClick.AddListener(delegate { options.ResetHighscores(); });
    }
}
