using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Score : GameEvent
{
    public TextMeshProUGUI scoreText;
    private float score;
    public void Update()
    {

        AddScore();
    }

    public void AddScore()
    {
        if (stopTime == true)
        { score += Time.deltaTime;
          scoreText.text = score.ToString("0");
        }
    }
}
