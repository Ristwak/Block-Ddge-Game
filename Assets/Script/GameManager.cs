using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float slowness = 10f;
    public void EndGame()
    {
        SceneManager.LoadScene("End");

        // StartCoroutine(Restartlevel());
    }

    //IEnumerator Restartlevel()
    //{
    //    Time.timeScale = 1f / slowness;
    //    Time.fixedDeltaTime = Time.timeScale/slowness;

    //    yield return new WaitForSeconds(1f / slowness);

    //    Time.timeScale = 1f;
    //    Time.fixedDeltaTime = Time.timeScale * slowness;

    //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    //}
}
