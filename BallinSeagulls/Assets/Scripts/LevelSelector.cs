using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    /// <summary>
    /// Loads scene using the scene name passed
    /// </summary>
    /// <param name="sceneName">The name of the scene to load</param>
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
