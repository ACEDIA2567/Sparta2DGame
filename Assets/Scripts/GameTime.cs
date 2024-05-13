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
        // 실제 시간으로 text에 출력되게 함
        timeText.text = DateTime.Now.ToString(("HH:mm"));
    }
}
