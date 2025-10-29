using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneController : MonoBehaviour
{
    public void SwitchScene (string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
