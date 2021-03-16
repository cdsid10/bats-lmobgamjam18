using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private int scenes;
    public void Play()
    {
        SceneManager.LoadScene(scenes);
    }

    public void Exit()
    {
        Application.Quit();
    }
    
}
