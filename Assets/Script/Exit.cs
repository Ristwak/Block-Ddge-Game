using TMPro;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    public void Quit()
    {
        Application.Quit();
    }

    void Start()
    {
        // Load the high score from PlayerPrefs and display it
        float highScore = PlayerPrefs.GetFloat("HighScore", 0f);
        string formattedHighScore = Score.FormatTime(highScore);
        scoreText.text = "High Score: " + formattedHighScore;
    }
}
