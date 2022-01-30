using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSession : MonoBehaviour
{
    
    private void Awake()
    {
        int numGameSessions = FindObjectsOfType<GameSession>().Length;
        if (numGameSessions > 1)
        { Destroy(gameObject); }
        else
        {
            DontDestroyOnLoad(gameObject);
        }

    }
    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void LoadLevel()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadCredits()
    {
        SceneManager.LoadScene(2);
    }
    public void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);        
    }
    public void Quit()
    {
        Application.Quit();
    }
}
