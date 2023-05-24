using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelButton : MonoBehaviour
{
    public void NextLevel(int sceneId)
    {
        SceneManager.LoadScene(sceneId);
    }
}
