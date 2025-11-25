using UnityEngine;
using Yarn.Unity;
using UnityEngine.SceneManagement;

public class SceneMnanager : MonoBehaviour
{
    [YarnCommand("LoadNextScene")]
    public void LoadNextScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}

