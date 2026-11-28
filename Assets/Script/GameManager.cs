
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float slowness = 10f;

    private bool gameHasEnded;

    public void EndGame()
    {
        if (gameHasEnded)
            return;

        gameHasEnded = true;

        SceneManager.LoadScene("End");
    }
}
