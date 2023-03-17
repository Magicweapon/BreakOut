using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallSpeedSlider : MonoBehaviour
{
    public Options options;
    private Slider speedSlider;

    private void Start()
    {
        speedSlider = GetComponent<Slider>();
        speedSlider.onValueChanged.AddListener(delegate { UpdateChanges(); });
    }
    public void UpdateChanges()
    {
        options.ChangeSpeed(speedSlider.value);
    }
}
