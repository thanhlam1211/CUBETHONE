﻿
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public void LoadNextLevel()
    {
        Debug.Log("Lam");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
