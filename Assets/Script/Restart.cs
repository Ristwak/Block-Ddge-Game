
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void RestartGame()
    {
        int mainLevelIndex = SceneUtility.GetBuildIndexByScenePath(
            "Assets/MainLevel.unity"
        );

        if (mainLevelIndex >= 0)
        {
            SceneManager.LoadScene(mainLevelIndex);
        }
        else
        {
            Debug.LogWarning(
                "MainLevel scene could not be found in the Build Settings."
            );
        }
    }
}
