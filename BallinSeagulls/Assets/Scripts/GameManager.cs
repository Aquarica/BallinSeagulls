using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    private NewPlayerController player;
    // may want to remove victoryCoroutine but probably not
    private Coroutine victoryCoroutine;

    private string currentScene;

    [SerializeField] private string nextScene;

    // change camera name
    public Camera mainCam;
    // I removed victory camera

    // public Transform deathHeight;

    // public int playerScore;

    // public float timer = 60;
    public float timer = 60;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<NewPlayerController>();  // Find player
        currentScene = SceneManager.GetActiveScene().name; // Get active scene name
    }

    // Update is called once per frame
    void Update()
    {
        switch (player.currentState)
        {
            case NewPlayerController.State.NORMAL:
                timer -= Time.deltaTime;    // Decrement timer

                // Timer runs out
                if (timer < 0.0f)
                {
                    // may want to change this later to lose state (50% sure dead is lose state)
                    player.currentState = NewPlayerController.State.DEAD;  // Set player's state to DEAD
                }
                break;
            case NewPlayerController.State.VICTORY:
                if (victoryCoroutine == null)
                    victoryCoroutine = StartCoroutine(Victory());       // Start victory procedure
                break;
        }
    }

    /// <summary>
    /// Waits a few seconds before reloading current scene.
    /// </summary>
    /// <returns></returns>
    /*
    IEnumerator FallingProcedure()
    {
        // Wait 1.5 secs then re load the scene
        yield return new WaitForSeconds(1.5f);
        LoadScene(currentScene);
    }
    */

    /// <summary>
    /// Enables\Disables the main and victory cameras, then waits a few second before loading the next scene.
    /// </summary>
    /// <returns></returns>
    // commenting out victory camera may cause problems
    IEnumerator Victory()
    {
        mainCam.enabled = false;    // Disable main camera
        // victoryCam.enabled = true;  // Enable victory camera

        // Wait 2.0 secs then load the next scene
        yield return new WaitForSeconds(2.0f);
        LoadScene(nextScene);
    }

    /// <summary>
    /// Loads scene using the scene name passed
    /// </summary>
    /// <param name="sceneName">The name of the scene to load</param>
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
