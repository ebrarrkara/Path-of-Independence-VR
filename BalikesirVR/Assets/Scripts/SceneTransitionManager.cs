using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionManager : MonoBehaviour
{
    // This function will be triggered by the VR laser pointer
    public void GoToScene(string sceneName)
    {
        Debug.Log("Teleporting to: " + sceneName);
        SceneManager.LoadScene(sceneName);
    }
}