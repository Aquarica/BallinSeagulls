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
    if(SceneManager.GetActiveScene()== SceneManager.GetSceneByName("Track1"))
    {
    SceneManager.LoadScene(2);   
    }
    if(SceneManager.GetActiveScene()== SceneManager.GetSceneByName("Track2"))
    {
    SceneManager.LoadScene(3);   
    }
    if(SceneManager.GetActiveScene()== SceneManager.GetSceneByName("Track3"))
    {
    SceneManager.LoadScene(4);   
    }
    if(SceneManager.GetActiveScene()== SceneManager.GetSceneByName("Track4"))
    {
    SceneManager.LoadScene(5);   
    }
}

// void OnTriggerEnter (Collider deathBox)
// {
//     SceneManager.LoadScene(sceneName);
// }
}
