
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    private float startTime;
    private float highScore;

    private const string HighScoreKey = "HighScore";

    private void Start()
    {
        startTime = Time.time;
        highScore = PlayerPrefs.GetFloat(HighScoreKey, 0f);
    }

    private void Update()
    {
        if (scoreText == null)
            return;

        float elapsedTime = Time.time - startTime;

        scoreText.text = "Time: " + FormatTime(elapsedTime);

        if (elapsedTime > highScore)
        {
            highScore = elapsedTime;

            PlayerPrefs.SetFloat(HighScoreKey, highScore);
            PlayerPrefs.Save();
        }
    }

    public static string FormatTime(float timeInSeconds)
    {
        int totalSeconds = Mathf.Max(0, Mathf.FloorToInt(timeInSeconds));

        int minutes = totalSeconds / 60;
        int seconds = totalSeconds % 60;

        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
