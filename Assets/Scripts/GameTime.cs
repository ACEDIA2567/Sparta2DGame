using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTime : MonoBehaviour
{
    private Text timeText;

    void Start()
    {
        timeText = GetComponent<Text>();
    }

    void Update()
    {
        timeText.text = DateTime.Now.ToString(("HH:mm"));
    }
}
