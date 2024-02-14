using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private float startTime;

    void Start()
    {
        // Record the initial time when the game starts
        startTime = Time.time;

        // Load the high score from PlayerPrefs and display it
        float highScore = PlayerPrefs.GetFloat("HighScore", 0f);
        string formattedHighScore = FormatTime(highScore);
        scoreText.text = "High Score: " + formattedHighScore;
    }

    void Update()
    {
        // Calculate the elapsed time since the game started
        float elapsedTime = Time.time - startTime;

        // Format the time as minutes and seconds
        string formattedTime = FormatTime(elapsedTime);

        // Display the formatted time in the UI Text component
        scoreText.text = "Time: " + formattedTime;

        // Check if the current time is greater than the stored high score
        if (elapsedTime > PlayerPrefs.GetFloat("HighScore", 0f))
        {
            // Update the high score in PlayerPrefs
            PlayerPrefs.SetFloat("HighScore", elapsedTime);
            PlayerPrefs.Save();

            // Update the displayed high score
            string formattedHighScore = FormatTime(elapsedTime);
            scoreText.text = "High Score: " + formattedHighScore;
        }
    }

    // Helper method to format time as minutes and seconds
    public static string FormatTime(float timeInSeconds)
    {
        int minutes = Mathf.FloorToInt(timeInSeconds / 60f);
        int seconds = Mathf.FloorToInt(timeInSeconds % 60f);
        string s = string.Format("{0:00}:{1:00}", minutes, seconds);

        return s;
    }
}
