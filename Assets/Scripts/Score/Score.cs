using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI resultScore;
    public TextMeshProUGUI highScore;
    public SOMyScore score;
    public static bool stopTime;
    void Start()
    {

        stopTime = false;
        Reset();
    }
    private void Reset()
    {
        score.myScore = 0f;
    }

    void Update()
    {
        if(stopTime == false)
        {
            score.myScore += Time.deltaTime;
            scoreText.text = score.myScore.ToString("0");
        }
        else
        { 
            resultScore.text = score.myScore.ToString("0");
            highScore.text = PlayerPrefs.GetFloat("HighScore", 0f).ToString("0");
            if(score.myScore > PlayerPrefs.GetFloat("HighScore", 0f))
            {
                PlayerPrefs.SetFloat("HighScore", score.myScore);
                highScore.text = score.myScore.ToString("0");
            }
        }
    }
}
