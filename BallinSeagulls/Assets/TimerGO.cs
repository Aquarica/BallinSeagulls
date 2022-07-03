using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TimerGO : MonoBehaviour
{
    float currentTime;
    public float startingTime = 2f;
    public Scene currentScene;
    public string sceneName;

    //public Collider deathBox;

    [SerializeField] TextMeshProUGUI countdownText;

    void Start()
    {
        currentTime = startingTime;
        currentScene = SceneManager.GetActiveScene ();
        sceneName = currentScene.name;
    }
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0.00");

        if (currentTime <= 0)
        {
            currentTime = 0;
            // What do you want to do when time hits ZERO?
            SceneManager.LoadScene(sceneName);
        }
    }

    void OnTriggerEnter (Collider deathBox)
    {
    SceneManager.LoadScene(sceneName);
    }
}