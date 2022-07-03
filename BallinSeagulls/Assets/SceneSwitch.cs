using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
//public Collider deathBox;
//public Collider levelEnd;

// public Scene currentScene;
// public string sceneName;

// void Start()
// {
//     currentScene = SceneManager.GetActiveScene ();
//     sceneName = currentScene.name;
// }

void OnTriggerEnter (Collider other)
{
    if(SceneManager.GetActiveScene()== SceneManager.GetSceneByName("DevTest"))
    {
    SceneManager.LoadScene(1);   
    }
}

// void OnTriggerEnter (Collider deathBox)
// {
//     SceneManager.LoadScene(sceneName);
// }
}
