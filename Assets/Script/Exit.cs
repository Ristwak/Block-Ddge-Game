
using TMPro;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    private void Start()
    {
        if (scoreText == null)
        {
            Debug.LogWarning("Score Text reference is missing.", this);
            return;
        }

        float highScore = PlayerPrefs.GetFloat("HighScore", 0f);

        scoreText.text = "High Score: " + Score.FormatTime(highScore);
    }

    public void Quit()
    {
        Application.Quit();

#if UNITY_EDITOR
        Debug.Log("Quit requested. Application.Quit does not close the Unity Editor.");
#endif
    }
}
