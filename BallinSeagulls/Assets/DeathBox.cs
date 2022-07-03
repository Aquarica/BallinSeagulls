using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathBox : MonoBehaviour
{
public Collider deathBox;

public Scene currentScene;
public string sceneName;

void Start()
{
    currentScene = SceneManager.GetActiveScene ();
    sceneName = currentScene.name;
}

void OnTriggerEnter (Collider deathBox)
{
    SceneManager.LoadScene(sceneName);
}
}